using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SecureCodeFull
{
    public partial class Login : Form
    {
        public string Usuario { get; private set; }
        //SQL CONNECTION
        BBDD.BBDDHeredado accdata = new BBDD.BBDDHeredado();
        HashUtils.HashUser haser = new HashUtils.HashUser();

        //ORIGINAL VARIABLES

        protected bool isDragging = false;
        protected Rectangle lastRectangle;
        protected string[] missatges = { "Benvingut", "Verificant nivell d'acces", "ACCES DENEGAT", "NO S'HA EMPLENAT L'USUARI", "ERROR DE BDD"};
        int[] lengths = new int[2];
        protected int timerTick;
        protected const double LOADTIME = 12; //TIMER LOAD TIME SEC
        protected double TICKCOUNT = LOADTIME * 10;
        protected int ERRTYPE;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "Select Password from Users where Login = '" + txtBoxUser.Text + "'";
                var dataTable = accdata.PortarPerConsulta(query).Tables[0];

                if (txtBoxUser.Text != "" && txtBoxPass.Text != "")
                {
                    string password = dataTable.Rows[0]["Password"].ToString();

                    if (dataTable.Rows.Count > 0)
                    {
                        string querySalt = "Select Salt from Users where Login = '" + txtBoxUser.Text + "'";
                        string salt = accdata.PortarPerConsulta(querySalt).Tables[0].Rows[0]["Salt"].ToString();
                        string contraseñaActual = haser.HashPassword(txtBoxPass.Text + salt);

                        if (password == "12345aA" && txtBoxPass.Text == "12345aA")
                        {
                            this.Hide();
                            ModiyUser frmpass = new ModiyUser(txtBoxUser.Text);
                            frmpass.Usuario = txtBoxUser.Text;
                            frmpass.ShowDialog();
                        }
                        else if (contraseñaActual == password)
                        {
                            timerLoadNext.Start();
                        }
                        else
                        {
                            ERRTYPE = 2;
                            timerFlash.Start();
                        }
                    }
                    else
                    {
                        ERRTYPE = 2;
                        timerFlash.Start();
                    }
                }
                else
                {
                    ERRTYPE = 3;
                    timerFlash.Start();
                }
            }
            catch
            {
                ERRTYPE = 2;
                timerFlash.Start();
            }
        }

        private void LoadNextForm()
        {
            splash spl = new splash();

            this.Hide();
            spl.Usuario = txtBoxUser.Text;
            spl.Show();
        }

        private void timerLoadNext_Tick(object sender, EventArgs e)
        {
            if (timerTick >= (int)TICKCOUNT)
            {
                LoadNextForm();
                timerLoadNext.Dispose();
            }
            else
            {
                switch (timerTick)
                {
                    case (10):
                        lblBenvingut.Text = missatges[0];
                        lblBenvingut.ForeColor = Color.Green;
                        lblBenvingut.Show();
                        break;
                    case (20):
                        lblUserData.Text = "Usuari: " + txtBoxUser.Text;
                        lblUserData.ForeColor = Color.Green;
                        lblUserData.Show();
                        break;
                    case 40:
                        lblComunicating.Text = missatges[1];
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
            if (timerTick <= 12 && timerLoadNext.Enabled == false)
            {
                if (ERRTYPE < 2 && ERRTYPE > missatges.Length)
                {
                    ERRTYPE = 1;
                }

                lblBenvingut.Text = missatges[ERRTYPE];
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
                timerTick = 0;
                timerFlash.Stop();
                lblBenvingut.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
