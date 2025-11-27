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
           
			string pattern = @"^[A-Z]{2}[0-9]{3}[A-Z]{2}$";
			string plaque = textBox_immatriculation.Text.ToUpper();

			// Vérification de la plaque AVANT de changer de formulaire
			if (!Regex.IsMatch(plaque, pattern))
			{
				MessageBox.Show("Plaque invalide. Format attendu : AB123CD");
				return;   // On bloque la validation
			}

			// Si tout est bon → on continue
			Form_acceuil formAccueil = new Form_acceuil();
			formAccueil.Show();
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