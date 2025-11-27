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

			// Vérification de la plaque AVANT de changer de formulaire
			if (!Regex.IsMatch(plaque, pattern))
			{
				MessageBox.Show("Plaque invalide. Format attendu : AB123CD");
				return;   // On bloque la validation
			}

			// Si tout est bon → on continue
			Form_Résumé formRésumé = new Form_Résumé();
			formRésumé.Show();
			this.Close();
		}
    }
}
