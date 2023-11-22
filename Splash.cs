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
    public partial class Splash : Form
    {
        protected bool isDragging = false;
        protected Rectangle lastRectangle;
        protected Random rnd = new Random();

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastRectangle = new Rectangle(e.Location.X, e.Location.Y, this.Width, this.Height);
            }
        }

        private void Splash_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int x = (this.Location.X + (e.Location.X - lastRectangle.X));
                int y = (this.Location.Y + (e.Location.Y - lastRectangle.Y));

                this.Location = new Point(x, y);
            }
        }

        private void Splash_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void timerLoadScreen_Tick(object sender, EventArgs e)
        {
            if (progBarSplash.Value != progBarSplash.Maximum)
            {
                int num = rnd.Next(5);

                if (num > 3) 
                {
                    progBarSplash.Step = 10;
                    progBarSplash.PerformStep();
                }
                else if (num == 4) 
                {
                    progBarSplash.Step = 15;
                    progBarSplash.PerformStep();
                }
            } 
            else if (progBarSplash.Value == progBarSplash.Maximum)
            {
                MainScreen main = new MainScreen();

                this.Hide();
                main.Show();

                timerLoadScreen.Dispose();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timerLoadScreen.Start();
        }
    }
}
