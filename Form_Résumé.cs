using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Déchetterie
{
    public partial class Form_Résumé : Form
    {
        public Form_Résumé()
        {
            InitializeComponent();
        }

        private void Form_Résumé_Load(object sender, EventArgs e)
        {
			label_Nom_Prenom.Text = DonneesChauffeur.NomPrenom;
			labelEntreprise.Text = DonneesChauffeur.Entreprise;
			labelDechet.Text = DonneesChauffeur.TypeDechet;
			labelPoids1.Text = DonneesChauffeur.Poids1 + " kg";
			labelPoids2.Text = DonneesChauffeur.Poids2 + " kg";
			labelPoidsnet.Text = DonneesChauffeur.PoidsNet + " kg";
			labelHorodatage.Text = DonneesChauffeur.DatePassage.ToString("dd/MM/yyyy HH:mm");
		}

        private void button_Retour_Click(object sender, EventArgs e)
        {

            Form_acceuil formAccueil = new Form_acceuil();
            formAccueil.Show();
            this.Close();
        }

        private void btn_Imprimer_Click(object sender, EventArgs e)
        {
            Form_acceuil formAccueil = new Form_acceuil();
            formAccueil.Show();
            this.Close();
        }

        private void label_Nom_Prenom_Click(object sender, EventArgs e)
        {

        }

        private void labelPoidsnet_Click(object sender, EventArgs e)
        {

        }
	}
}
