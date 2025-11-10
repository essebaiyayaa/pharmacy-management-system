using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPharmacie
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void connecter_Click(object sender, EventArgs e)
        {

            if (txtemail.Text == "" || txtpassword.Text == "")
            {
                messageErreur.Text = "Veuillez remplir tous les champs";
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source =DESKTOP-OES6LFO\\GI2;initial catalog = pharmacie;" +
                    "integrated security = True;TrustServerCertificate=True";
                String sql = "select * from Pharmacien where email = '" + txtemail.Text + "' and mot_de_passe = '" + txtpassword.Text + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    messageErreur.Text = "Veuillez remplir les bonnes informations";
                }

            }
        }
    }
}
