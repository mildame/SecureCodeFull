using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SecureCodeFull
{
    public partial class ModiyUser : Form
    {
        HashUtils.HashUser hsh = new HashUtils.HashUser();
        private Timer timer;

        public ModiyUser()
        {
            InitializeComponent();
            InitializeTimer();
            label3.Hide();
        }

        protected bool checkPassword(string text1, string text2) {

            bool match = false;

            if (text1.Equals(text2)) {
                match = true;
            }

            return match;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool confirm;
            string salt;
            string password;
            string passwordSalt;
            string hashPass;

            confirm = checkPassword(textBox1.Text, textBox2.Text);

            if (confirm)
            {
                salt = hsh.createSalt();
                password = hsh.createPassword(label1.Text);
                passwordSalt = password + salt;
                hashPass = hsh.hashPassword(passwordSalt); //hashed password para guardaar a la basede dades

                label3.Hide();
                MessageBox.Show("Password Saved");
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
    }   
}
