using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionPharmacie
{
    public partial class Medicaments : Form
    {
        public Medicaments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Medicaments_Load(object sender, EventArgs e)
        {
            ChargerMedicaments();
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gridview.Columns[e.ColumnIndex].Name == "Modifier")
            {
                // Récupérer les nouvelles valeurs directement depuis la ligne modifiée
                int id = Convert.ToInt32(gridview.Rows[e.RowIndex].Cells["id_medicament"].Value);
                string reference = gridview.Rows[e.RowIndex].Cells["reference"].Value.ToString();
                string nom = gridview.Rows[e.RowIndex].Cells["nom"].Value.ToString();
                string description = gridview.Rows[e.RowIndex].Cells["description"].Value.ToString();
                decimal prix = Convert.ToDecimal(gridview.Rows[e.RowIndex].Cells["prix"].Value);
                int quantite = Convert.ToInt32(gridview.Rows[e.RowIndex].Cells["quantite"].Value);
                int seuil = Convert.ToInt32(gridview.Rows[e.RowIndex].Cells["seuil_alerte"].Value);
                DateTime datePeremption = Convert.ToDateTime(gridview.Rows[e.RowIndex].Cells["date_peremption"].Value);

                // Création de l’objet Medicament
                Medicament med = new Medicament
                {
                    Id = id,
                    Reference = reference,
                    Nom = nom,
                    Description = description,
                    Prix = prix,
                    Quantite = quantite,
                    SeuilAlerte = seuil,
                    DatePeremption = datePeremption
                };
                // Appel de la méthode Modifier
                bool ok = med.Modifier();

            }
        }

        private void medicament_Click(object sender, EventArgs e)
        {
            Medicaments medicaments = new Medicaments();
            medicaments.Show();
            this.Hide();
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            string valeur = txtrechercher.Text.Trim();

            Medicament med = new Medicament();

            DataTable dt = med.RechercherGlobal(valeur);

            gridview.DataSource = dt;
        }

        private void ajouterMedicament_Click(object sender, EventArgs e)
        {
            AjouterMedicament ajouterMedicament = new AjouterMedicament();
            ajouterMedicament.Show();
            this.Hide();
        }

        private void txtrechercher_TextChanged(object sender, EventArgs e)
        {

        }
        private void ChargerMedicaments()
        {
            Medicament med = new Medicament();
            DataTable dt = med.GetAllMedicaments();
            gridview.DataSource = dt;

            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 🔹 Renommer les entêtes de colonnes
            if (gridview.Columns.Contains("reference"))
                gridview.Columns["reference"].HeaderText = "Référence";
            if (gridview.Columns.Contains("nom"))
                gridview.Columns["nom"].HeaderText = "Nom";
            if (gridview.Columns.Contains("description"))
                gridview.Columns["description"].HeaderText = "Description";
            if (gridview.Columns.Contains("prix"))
                gridview.Columns["prix"].HeaderText = "Prix (DH)";
            if (gridview.Columns.Contains("quantite"))
                gridview.Columns["quantite"].HeaderText = "Quantité";
            if (gridview.Columns.Contains("seuil_alerte"))
                gridview.Columns["seuil_alerte"].HeaderText = "Seuil d’Alerte";
            if (gridview.Columns.Contains("date_peremption"))
                gridview.Columns["date_peremption"].HeaderText = "Date de Péremption";

            // Ajout du bouton Modifier si non déjà présent
            if (!gridview.Columns.Contains("Modifier"))
            {
                DataGridViewButtonColumn btnModifier = new DataGridViewButtonColumn();
                btnModifier.Name = "Modifier";
                btnModifier.HeaderText = "Action";
                btnModifier.Text = "Modifier";
                btnModifier.UseColumnTextForButtonValue = true;
                gridview.Columns.Add(btnModifier);
            }

            // Rendre les cellules modifiables
            gridview.ReadOnly = false;
            gridview.Columns["id_medicament"].Visible = false;
        }

        private void alertes_Click(object sender, EventArgs e)
        {
            Alertes listeAlertes = new Alertes();
            listeAlertes.Show();
            this.Hide();
        }
    }
}
