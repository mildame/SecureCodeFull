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
    public partial class MainProvaMarc : Form
    {
        public string Usuario { get; set; }
        BBDD.BBDDHeredado accdata = new BBDD.BBDDHeredado();
        public MainProvaMarc()
        {
            InitializeComponent();         
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void MainProvaMarc_Load(object sender, EventArgs e)
        {
            lblnombreUser.Text = "Usuario: " + Usuario;
            CargarDatosTabla();
        }
        public void MostrarBotones(DataSet datasetTabla)
        {
            DataSet datasSet = datasetTabla;

            foreach (DataRow row in datasSet.Tables[0].Rows)
            {
                SWLauchForm.SWLauchForm boton = new SWLauchForm.SWLauchForm();

                boton.Descripcion = row["Descripcio"].ToString() as String;
                boton.Classe = row["Classe"].ToString();
                boton.Form = row["Formulari"].ToString();
                boton.Img = row["Imatge"].ToString();
                boton.Tabla = row["Taula"].ToString();
                boton.User = Usuario;

                fpbotones.Controls.Add(boton);
            }
        }

        private void CargarDatosTabla()
        {
            string query = "select idUserCategory from Users where UserName='" + Usuario + "'";
            string idUserCat = accdata.PortarPerConsulta(query).Tables[0].Rows[0]["idUserCategory"].ToString(); 
            string query2 = "select AccessLevel from UserCategories where idUserCategory = '" + idUserCat + "'";
            string accessLevel = accdata.PortarPerConsulta(query2).Tables[0].Rows[0]["AccessLevel"].ToString(); 
            string query3 = "select * from UserOptions where minLevel <= " + accessLevel + " order by VisualOrder";
            DataSet dtsUserRank = accdata.PortarPerConsulta(query3);
            MostrarBotones(dtsUserRank);
        }
    }
}
