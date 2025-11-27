using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Déchetterie
{
    public partial class Form_Enregistrement : Form
    {
        public Form_Enregistrement()
        {
            InitializeComponent();
        }
        private void button_Retour_Click(object sender, EventArgs e)
        {
            Form_acceuil formAccueil = new Form_acceuil();
            formAccueil.Show();
            this.Close();
        }

        private void Form_Enregistrement_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Prenom_TextChanged(object sender, EventArgs e)
        {

        }
		private void button_Valider_Click(object sender, EventArgs e)
		{
			string nom = textBox_Nom.Text;
			string prenom = textBox_Prenom.Text;
			string entreprise = textBox_entreprise.Text;
			string plaque = textBox_immatriculation.Text.ToUpper();
			string typeDechet = comboBox_Dechet.Text;

			// Vérification de plaque
			string pattern = @"^[A-Z]{2}[0-9]{3}[A-Z]{2}$";
			if (!Regex.IsMatch(plaque, pattern))
			{
				MessageBox.Show("Format plaque invalide !");
				return;
			}

			using (var conn = Database.GetConnection())
			{
				conn.Open();

				// → Insérer le chauffeur
				string sql1 = "INSERT INTO chauffeur (nom, prenom, entreprise, plaque) VALUES (@nom, @prenom, @ent, @plaque)";
				MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
				cmd1.Parameters.AddWithValue("@nom", nom);
				cmd1.Parameters.AddWithValue("@prenom", prenom);
				cmd1.Parameters.AddWithValue("@ent", entreprise);
				cmd1.Parameters.AddWithValue("@plaque", plaque);
				cmd1.ExecuteNonQuery();

				long idChauffeur = cmd1.LastInsertedId;

				// → Trouver le type de déchet
				string sql2 = "SELECT id_dechet FROM dechets WHERE type = @type LIMIT 1";
				MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
				cmd2.Parameters.AddWithValue("@type", typeDechet);

				long idDechet = Convert.ToInt32(cmd2.ExecuteScalar());

				// → Insérer un passage (poids1 sera rempli plus tard)
				string sql3 = "INSERT INTO passages (id_chauffeur, id_dechet, poids1, poids2) VALUES (@idc, @idd, 0, 0)";
				MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
				cmd3.Parameters.AddWithValue("@idc", idChauffeur);
				cmd3.Parameters.AddWithValue("@idd", idDechet);
				cmd3.ExecuteNonQuery();
			}

			MessageBox.Show("Enregistrement effectué !");
			this.Close();
		}


		private void label_prix_Click(object sender, EventArgs e)
        {

        }

        private void label_Nom_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Dechet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Dechet.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox_Nom_TextChanged(object sender, EventArgs e)
        {

        }
		private void textBox_entreprise_TextChanged(object sender, EventArgs e)

		{
		}
		private void textBox_immatriculation_TextChanged(object sender, EventArgs e)
        {
			
		}
    }
}