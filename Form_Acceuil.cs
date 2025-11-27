namespace Déchetterie
{
    public partial class Form_acceuil : Form
    {
        public Form_acceuil()
        {
            InitializeComponent();
        }


        private void btn_Enregistrement_Click(object sender, EventArgs e)
        {

            Form_Enregistrement formEnregistrement = new Form_Enregistrement();

            formEnregistrement.Show();
            this.Hide();
        }


        private void btn_Identification_Click(object sender, EventArgs e)
        {

            Form_Identification formIdentification = new Form_Identification();

            formIdentification.Show();
            this.Hide();
        }

        private void Form_acceuil_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}