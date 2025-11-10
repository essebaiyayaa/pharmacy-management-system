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
    public partial class Alertes : Form
    {
        public Alertes()
        {
            InitializeComponent();
        }

        private void medicament_Click(object sender, EventArgs e)
        {
            Medicaments medicaments = new Medicaments();
            medicaments.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Alertes listeAlertes = new Alertes();
            listeAlertes.Show();
            this.Hide();
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ChargerMedicamentsEnAlerte()
        {
            Medicament medicament = new Medicament();
            DataTable dt = medicament.GetMedicamentsEnAlertePeremption(30); // 30 jours avant péremption
            gridview.DataSource = dt;

            // Optionnel : améliorer l'affichage
            gridview.Columns["reference"].HeaderText = "Référence";
            gridview.Columns["nom"].HeaderText = "Nom";
            gridview.Columns["description"].HeaderText = "Description";
            gridview.Columns["prix"].HeaderText = "Prix (DH)";
            gridview.Columns["quantite"].HeaderText = "Quantité";
            gridview.Columns["seuil_alerte"].HeaderText = "Seuil d'Alerte";
            gridview.Columns["date_peremption"].HeaderText = "Date de Péremption";

            // Optionnel : colorer les lignes en fonction du nombre de jours restants
            foreach (DataGridViewRow row in gridview.Rows)
            {
                if (row.Cells["date_peremption"].Value != null)
                {
                    DateTime datePeremption = Convert.ToDateTime(row.Cells["date_peremption"].Value);
                    int joursRestants = (datePeremption - DateTime.Now).Days;

                    if (joursRestants <= 7)
                        row.DefaultCellStyle.BackColor = Color.LightCoral; // rouge clair
                    else if (joursRestants <= 15)
                        row.DefaultCellStyle.BackColor = Color.Khaki; // jaune
                    else
                        row.DefaultCellStyle.BackColor = Color.LightGreen; // vert clair
                }
            }
        }

        private void Alertes_Load(object sender, EventArgs e)
        {
            ChargerMedicamentsEnAlerte();
        }
    }
}
