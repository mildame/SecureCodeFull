using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCodeFull
{
    public partial class ModiyUser : Form
    {
        public string Usuario { get; set; }
        private Timer timer;
        BBDD.BBDDHeredado dbs = new BBDD.BBDDHeredado   ();
        HashUtils.HashUser hsh = new HashUtils.HashUser();
        SecureCodeFull.Login lgn = new SecureCodeFull.Login();
        string nombrelog;
        bool confirm;

        public ModiyUser(string login)
        {
            nombrelog = login;
            InitializeComponent();
            InitializeTimer();
            label3.Hide();
        }

        protected bool checkPassword(string text1, string text2) {

            bool match = false;
            if (text1.Equals(text2))
            {
                match = true;
            }
            return match;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            confirm = checkPassword(textBox1.Text, textBox2.Text);

            if (confirm && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                label3.Hide();
                click();
                this.Hide();
                //when confirm, close the modal 
            }
            else
            {
                showText();
            }
        }

        private void InitializeTimer() {
            timer = new Timer();
            timer.Interval = 5000; // 3000 milliseconds = 3 seconds
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Reset the label text after 5 seconds
            label3.Text = "Password Mismatch!";
            timer.Stop();
            label3.Hide();
        }

        private void showText() {

            label3.Show();
            label3.Text = ("Password Mismatch");
            timer.Start();
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public void click()
        {

            string salto = hsh.createSalt();
            if (textBox1.Text == textBox2.Text && textBox1.Text != "")
            {
                string strHash1 = hsh.HashPassword(textBox2.Text + salto);

                string query = "UPDATE Users SET[Password] = '" + strHash1 + "' WHERE[Login] = '" + Usuario + "'";
                dbs.Executa(query);

                string query2 = "UPDATE Users SET[Salt] = '" + salto + "' WHERE[Login] = '" + Usuario + "'";
                dbs.Executa(query2);
                //almacenar en BD pssw hasheado

                this.Hide();
                splash spl = new splash();
                spl.Usuario = Usuario;
                spl.Show();
            }
            else
            {
                label3.Text = ("");
                label3.Text = ("Las contraseñas no coinciden");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
