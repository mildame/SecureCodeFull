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
    public partial class splash : Form
    {
        public string Usuario { get; set; }
        public splash()
        {
            InitializeComponent();
            timer1.Start();
            this.StartPosition = FormStartPosition.CenterScreen;
            circProgBar.Value = 0;
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Incrementa el valor del ProgressBar en 10 unidades (10%)
            circProgBar.Value += 2;

            // Verifica si ha alcanzado el 100%
            if (circProgBar.Value == circProgBar.Maximum)
            {
                // Detén el Timer
                timer1.Enabled = false;

                MainProvaMarc main = new MainProvaMarc();
                main.Usuario = Usuario;
                main.Show();
                this.Hide();
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
     

        private void timerSplash_Tick(object sender, EventArgs e)
        {
          
        }

    }
}
