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
    public partial class AjouterMedicament : Form
    {
        public AjouterMedicament()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Medicaments medicaments = new Medicaments();
            medicaments.Show();
            this.Hide();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            // Vérification minimale
            if (txtreference.Text == "" || txtnom.Text == "" || txtquantite.Text == "" || txtprix.Text == ""
                || txtseuil.Text == "" || txtdate.Text == "" || txtdescription.Text == "") { 
                labMessage.Text = "Veuillez remplir tous les champs.";
            }
            Medicament med = new Medicament();

            med.Reference = txtreference.Text.Trim();
            med.Nom = txtnom.Text.Trim();
            med.Description = txtdescription.Text.Trim();
            med.Prix = decimal.Parse(txtprix.Text.Trim());
            med.Quantite = int.Parse(txtquantite.Text.Trim());
            med.SeuilAlerte = int.Parse(txtseuil.Text.Trim());
            med.DatePeremption = txtdate.Value.Date;

            bool resultat = med.Ajouter();

            if (resultat)
            {
                labMessage.Text = "Médicament ajouté avec succès.";

                // Réinitialiser le formulaire après ajout
                txtreference.Clear();
                txtnom.Clear();
                txtdescription.Clear();
                txtprix.Clear();
                txtquantite.Clear();
                txtseuil.Clear();
                txtdate.Value = DateTime.Now;
            }
            else
            {
                labMessage.Text= "Erreur lors de l'ajout du médicament.";
            }
        }
    }
}
