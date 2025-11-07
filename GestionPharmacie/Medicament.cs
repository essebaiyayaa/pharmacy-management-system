using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie
{
    internal class Medicament
    {
        // Attributs (correspondant à la table Medicament)
        private int id_medicament;
        private string reference;
        private string nom;
        private string description;
        private double prix;
        private int quantite;
        private int seuil_alerte;
        private DateTime date_ajout;
        private DateTime date_peremption;

        // Getters / Setters
        public int Id_Medicament
        {
            get { return id_medicament; }
            set { id_medicament = value; }
        }

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public int SeuilAlerte
        {
            get { return seuil_alerte; }
            set { seuil_alerte = value; }
        }

        public DateTime DateAjout
        {
            get { return date_ajout; }
            set { date_ajout = value; }
        }

        public DateTime DatePeremption
        {
            get { return date_peremption; }
            set { date_peremption = value; }
        }

        // Chaîne de connexion (adapter si besoin)
        private string connectionString =
            "data source=DESKTOP-OES6LFO\\GI2;initial catalog=pharmacie;integrated security=True;TrustServerCertificate=True";

        // Constructeurs
        public Medicament() { }

        public Medicament(int id_medicament, string reference, string nom, string description, double prix, int quantite, int seuil_alerte, DateTime date_ajout, DateTime date_peremption)
        {
            this.id_medicament = id_medicament;
            this.reference = reference;
            this.nom = nom;
            this.description = description;
            this.prix = prix;
            this.quantite = quantite;
            this.seuil_alerte = seuil_alerte;
            this.date_ajout = date_ajout;
            this.date_peremption = date_peremption;
        }

        // Ajouter un médicament (ne passe pas l'id car identity; date_ajout laissé au défaut SQL si souhaité)
        public void AjouterMedicament()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO Medicament (reference, nom, description, prix, quantite, seuil_alerte, date_peremption)
                               VALUES (@reference, @nom, @description, @prix, @quantite, @seuil_alerte, @date_peremption)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@reference", reference ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@nom", nom ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@description", description ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@prix", prix);
                cmd.Parameters.AddWithValue("@quantite", quantite);
                cmd.Parameters.AddWithValue("@seuil_alerte", seuil_alerte);
                cmd.Parameters.AddWithValue("@date_peremption", date_peremption);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Modifier un médicament (par id)
        public void ModifierMedicament()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE Medicament
                               SET reference=@reference,
                                   nom=@nom,
                                   description=@description,
                                   prix=@prix,
                                   quantite=@quantite,
                                   seuil_alerte=@seuil_alerte,
                                   date_peremption=@date_peremption
                               WHERE id_medicament=@id_medicament";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id_medicament", id_medicament);
                cmd.Parameters.AddWithValue("@reference", reference ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@nom", nom ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@description", description ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@prix", prix);
                cmd.Parameters.AddWithValue("@quantite", quantite);
                cmd.Parameters.AddWithValue("@seuil_alerte", seuil_alerte);
                cmd.Parameters.AddWithValue("@date_peremption", date_peremption);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Supprimer un médicament (par id)
        public void SupprimerMedicament()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Medicament WHERE id_medicament=@id_medicament";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id_medicament", id_medicament);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Chercher un médicament (par id_medicament) — retourne true si trouvé et remplit les champs
        public bool ChercherMedicament()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Medicament WHERE id_medicament=@id_medicament";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id_medicament", id_medicament);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reference = reader["reference"] != DBNull.Value ? reader["reference"].ToString() : null;
                    nom = reader["nom"] != DBNull.Value ? reader["nom"].ToString() : null;
                    description = reader["description"] != DBNull.Value ? reader["description"].ToString() : null;
                    prix = reader["prix"] != DBNull.Value ? Convert.ToDouble(reader["prix"]) : 0.0;
                    quantite = reader["quantite"] != DBNull.Value ? Convert.ToInt32(reader["quantite"]) : 0;
                    seuil_alerte = reader["seuil_alerte"] != DBNull.Value ? Convert.ToInt32(reader["seuil_alerte"]) : 0;
                    date_ajout = reader["date_ajout"] != DBNull.Value ? Convert.ToDateTime(reader["date_ajout"]) : DateTime.MinValue;
                    date_peremption = reader["date_peremption"] != DBNull.Value ? Convert.ToDateTime(reader["date_peremption"]) : DateTime.MinValue;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // Récupérer la liste des médicaments en alerte (quantité <= seuil_alerte OR périme dans X jours)
        public List<Medicament> ListeMedicamentsEnAlerte(int joursAvantPeremption = 30)
        {
            List<Medicament> liste = new List<Medicament>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT * FROM Medicament
                               WHERE quantite <= seuil_alerte
                                  OR date_peremption <= DATEADD(day, @jours, GETDATE())";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@jours", joursAvantPeremption);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Medicament m = new Medicament
                    {
                        id_medicament = reader["id_medicament"] != DBNull.Value ? Convert.ToInt32(reader["id_medicament"]) : 0,
                        reference = reader["reference"] != DBNull.Value ? reader["reference"].ToString() : null,
                        nom = reader["nom"] != DBNull.Value ? reader["nom"].ToString() : null,
                        description = reader["description"] != DBNull.Value ? reader["description"].ToString() : null,
                        prix = reader["prix"] != DBNull.Value ? Convert.ToDouble(reader["prix"]) : 0.0,
                        quantite = reader["quantite"] != DBNull.Value ? Convert.ToInt32(reader["quantite"]) : 0,
                        seuil_alerte = reader["seuil_alerte"] != DBNull.Value ? Convert.ToInt32(reader["seuil_alerte"]) : 0,
                        date_ajout = reader["date_ajout"] != DBNull.Value ? Convert.ToDateTime(reader["date_ajout"]) : DateTime.MinValue,
                        date_peremption = reader["date_peremption"] != DBNull.Value ? Convert.ToDateTime(reader["date_peremption"]) : DateTime.MinValue
                    };
                    liste.Add(m);
                }
            }

            return liste;
        }
    }
}
