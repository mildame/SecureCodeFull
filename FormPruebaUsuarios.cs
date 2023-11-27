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
    public partial class FormPruebaUsuarios : Form
    {
        public FormPruebaUsuarios()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        private string query;
        DataSet dts;
        private bool nou;
        private void ConfigurarConnexio()
        {
            string cnx;
            cnx = "Data Source=sqlserver.S2AM.sdslab.cat;Initial Catalog=SecureCoreG1;Persist Security Info=True;User ID=G1;Password=12345aAG12324.";
            conn = new SqlConnection(cnx);
        }

        private void PortarDades()
        {
            ConfigurarConnexio();
            SqlDataAdapter adapter;
            dts = new DataSet();

            query = "select * from Users";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, "SecureCoreG1");
            dgUsers.DataSource = dts.Tables[0];

            conn.Close();

        }
        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (((TextBox)sender).DataBindings.Count > 0)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }

        }

        private void FormPruebaUsuarios_Load(object sender, EventArgs e)
        {
            PortarDades();
        }
    }
}
