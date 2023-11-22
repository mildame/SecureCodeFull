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
    public partial class MainScreen : Form
    {
        prova frm = new prova();
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnExitLogin_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crearNewForm()
        {
            frm = new prova();
            frm.SetBounds(264, 91, panel1.Width, panel1.Height); //Leak de memoria, es poden crear infinits, ns com arreglar-ho ara mateix
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Dispose();
            crearNewForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Dispose();
            crearNewForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm.Dispose();
            crearNewForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            crearNewForm();
        }
    }
}
