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
    public partial class Login : Form
    {
        //Acceso a BBDD
        ConexionBBDD.

        //Cositas
        protected bool isDragging = false;
        protected Rectangle lastRectangle;
        protected string[] missatges = { "Benvingut, ", "ACCES DENEGAT", "Verificant nivell d'acces" };
        int[] lengths = new int[2];
        protected int timerTick;
        protected const double LOADTIME = 12; //TIMER LOAD TIME SEC
        protected double TICKCOUNT;
        public Login()
        {
            InitializeComponent();

            paintBackColors();
            hideLabels();
        }
        private void paintBackColors()
        {
            btnValidar.BackColor = ColorTranslator.FromHtml("#031010");
            lblBenvingut.BackColor = ColorTranslator.FromHtml("#031010");
            lblUserData.BackColor = ColorTranslator.FromHtml("#031010");
            lblComunicating.BackColor = ColorTranslator.FromHtml("#031010");
        }

        private void hideLabels()
        {
            lblBenvingut.Hide();
            lblUserData.Hide();
            lblComunicating.Hide();
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastRectangle = new Rectangle(e.Location.X, e.Location.Y, this.Width, this.Height);
            }
        }
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int x = (this.Location.X + (e.Location.X - lastRectangle.X));
                int y = (this.Location.Y + (e.Location.Y - lastRectangle.Y));

                this.Location = new Point(x, y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateUser()
        {
            if (txtBoxUser.Text.Equals("admin") && txtBoxPass.Text.Equals("admin")) return true;
            
            return false;
        }

        private void LoadNextForm()
        {
            Splash splash = new Splash();

            this.Hide();
            splash.Show();
        }

        private void timerLoadNext_Tick(object sender, EventArgs e)
        {
            if (timerTick >= (int)TICKCOUNT)
            {
                LoadNextForm();
                timerLoadNext.Dispose();
            }
            /*else if (timerTick == 0)
            {
                lengths[0] = missatges[0].Length + txtBoxUser.Text.Length;
                lengths[1] = userALL[0, 2].Length;
                lengths[2] = missatges[2].Length;
            }
            */
            else
            {
                switch (timerTick)
                {
                    case (10):
                        lblBenvingut.Text = missatges[0] + "admin";
                        lblBenvingut.ForeColor = Color.Green;
                        lblBenvingut.Show();
                        break;
                    case (20):
                        lblUserData.Text = "admin" + "\n" + "Administrador del Sistema";
                        lblUserData.ForeColor = Color.Green;
                        lblUserData.Show();
                        break;
                    case 40:
                        lblComunicating.Text = missatges[2];
                        lblComunicating.ForeColor = Color.Green;
                        lblComunicating.Show();
                        break;
                    default:
                        if (timerTick >= 40 && timerTick < TICKCOUNT - 10)
                        {
                            int length = lblComunicating.Text.Length;
                            int numDots = 3;

                            string dots = setDots(numDots);

                            if (lblComunicating.Text.Substring(length - numDots, numDots).Equals(dots))
                            {
                                lblComunicating.Text = lblComunicating.Text.Substring(0, length - numDots);
                            }
                            else
                            {
                                lblComunicating.Text = lblComunicating.Text + ".";
                            }
                        }
                        else
                        {
                            lblComunicating.Text = "        VERIFICAT!";
                        }
                        break;
                }
            }

            timerTick++;
        }

        private string setDots(int dotnum)
        {
            string dots = "";

            for (int i = 1; i <= dotnum; i++)
            {
                dots = dots + ".";
            }

            return dots;
        }

        private void timerFlash_Tick(object sender, EventArgs e)
        {
            if(timerTick <= 12 && timerLoadNext.Enabled == false)
            {
                lblBenvingut.Text = missatges[1];
                lblBenvingut.ForeColor = Color.Red;

                if (timerTick % 2 != 0)
                {       
                    lblBenvingut.Hide();
                }
                else
                {
                    lblBenvingut.Show();
                }
                timerTick++;
            }
            else
            {
                timerFlash.Dispose();
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool userValidated = ValidateUser();
            timerTick = 0;
            lblBenvingut.Hide();
            lblComunicating.Hide();
            lblUserData.Hide();


            if (userValidated)
            {
                double interval = timerLoadNext.Interval;

                TICKCOUNT = LOADTIME / (interval / 1000);
                timerLoadNext.Start();
            }
            else
            {
                timerFlash.Start();
            }
        }
    }
}
