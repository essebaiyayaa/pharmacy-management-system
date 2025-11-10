using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie
{
    internal class Medicament
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public int Quantite { get; set; }
        public int SeuilAlerte { get; set; }
        public DateTime DatePeremption { get; set; }

        // Mets ici ta chaîne de connexion SQL Server
        private string connectionString = @"data source=DESKTOP-OES6LFO\GI2;initial catalog=pharmacie;integrated security=True;TrustServerCertificate=True";


        // ------------------------------------------------------
        // Ajouter un médicament
        // ------------------------------------------------------
        public bool Ajouter()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Medicament 
                             (reference, nom, description, prix, quantite, seuil_alerte, date_peremption)
                             VALUES (@ref, @nom, @desc, @prix, @qte, @seuil, @peremption)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ref", Reference);
                cmd.Parameters.AddWithValue("@nom", Nom);
                cmd.Parameters.AddWithValue("@desc", Description);
                cmd.Parameters.AddWithValue("@prix", Prix);
                cmd.Parameters.AddWithValue("@qte", Quantite);
                cmd.Parameters.AddWithValue("@seuil", SeuilAlerte);
                cmd.Parameters.AddWithValue("@peremption", DatePeremption);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ------------------------------------------------------
        // Modifier un médicament
        // ------------------------------------------------------
        public bool Modifier()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Medicament SET 
                            reference = @ref,
                            nom = @nom,
                            description = @desc,
                            prix = @prix,
                            quantite = @qte,
                            seuil_alerte = @seuil,
                            date_peremption = @peremption
                         WHERE id_medicament = @id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ref", Reference);
                cmd.Parameters.AddWithValue("@nom", Nom);
                cmd.Parameters.AddWithValue("@desc", Description);
                cmd.Parameters.AddWithValue("@prix", Prix);
                cmd.Parameters.AddWithValue("@qte", Quantite);
                cmd.Parameters.AddWithValue("@seuil", SeuilAlerte);
                cmd.Parameters.AddWithValue("@peremption", DatePeremption);
                cmd.Parameters.AddWithValue("@id", Id);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable RechercherGlobal(string valeur)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                            reference,
                            nom,
                            description,
                            prix,
                            quantite,
                            seuil_alerte,
                            date_peremption
                         FROM Medicament
                         WHERE reference LIKE @val
                         OR nom LIKE @val
                         OR description LIKE @val
                         OR CONVERT(VARCHAR(10), date_peremption, 120) LIKE @val";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@val", "%" + valeur + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        public DataTable GetAllMedicaments()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                            id_medicament,
                            reference,
                            nom,
                            description,
                            prix,
                            quantite,
                            seuil_alerte,
                            date_peremption
                         FROM Medicament";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetMedicamentsEnAlertePeremption(int joursAvant = 30)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
    SELECT 
        reference,
        nom,
        description,
        prix,
        quantite,
        seuil_alerte,
        date_peremption
    FROM Medicament
    WHERE DATEDIFF(day, GETDATE(), date_peremption) <= @jours
    AND DATEDIFF(day, GETDATE(), date_peremption) >= 0
    ORDER BY date_peremption ASC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@jours", joursAvant);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
