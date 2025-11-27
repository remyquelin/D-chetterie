using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Déchetterie
{
    public partial class Form_Identification : Form
    {
        public Form_Identification()
        {
            InitializeComponent();
        }

        private void Form_Identification_Load(object sender, EventArgs e)
        {

        }

        private void button_Retour_Click(object sender, EventArgs e)
        {
            // Créer une nouvelle instance de Form_acceuil
            Form_acceuil formAccueil = new Form_acceuil();

            // Afficher la nouvelle fenêtre
            formAccueil.Show();

            // Fermer la fenêtre actuelle (Form_Enregistrement)
            this.Close();
        }


        private void label_plaqueimmatriculation_Click(object sender, EventArgs e)
        {

        }

		private void button_Valider_Click(object sender, EventArgs e)
		{
			string pattern = @"^[A-Z]{2}[0-9]{3}[A-Z]{2}$";
			string plaque = textBox_immatriculation.Text.ToUpper();

			// Vérification du format de la plaque
			if (!Regex.IsMatch(plaque, pattern))
			{
				MessageBox.Show("Plaque invalide. Format attendu : AB123CD");
				return;
			}

			// Si le format est bon → Recherche en BDD
			using (var conn = Database.GetConnection())
			{
				conn.Open();

				string sql = @"
            SELECT ch.nom, ch.prenom, ch.entreprise, d.type, 
                   p.poids1, p.poids2, p.date_passage
            FROM passages p
            JOIN chauffeur ch ON p.id_chauffeur = ch.id_chauffeur
            JOIN dechets d ON p.id_dechet = d.id_dechet
            WHERE ch.plaque = @plaque
            ORDER BY p.date_passage DESC
            LIMIT 1";

				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@plaque", plaque);

				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						// On stocke les infos dans des variables statiques
						DonneesChauffeur.NomPrenom = reader.GetString("nom") + " " + reader.GetString("prenom");
						DonneesChauffeur.Entreprise = reader.GetString("entreprise");
						DonneesChauffeur.TypeDechet = reader.GetString("type");
						DonneesChauffeur.Poids1 = reader.GetDecimal("poids1");
						DonneesChauffeur.Poids2 = reader.GetDecimal("poids2");
						DonneesChauffeur.DatePassage = reader.GetDateTime("date_passage");

						Form_Résumé resume = new Form_Résumé();
						resume.Show();
						this.Close();
					}
					else
					{
						MessageBox.Show("Aucun chauffeur trouvé !");
					}
				}
			}
		}

	}
}
