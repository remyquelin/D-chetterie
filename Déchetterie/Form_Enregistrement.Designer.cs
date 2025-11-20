namespace Déchetterie
{
    partial class Form_Enregistrement
    {
        private const string V = "Nom de l'entreprise";

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Enregistrement));
            label_Prénom = new Label();
            label_Nom = new Label();
            label_entreprise = new Label();
            label_Immatriculation = new Label();
            label_dechet = new Label();
            label_prix = new Label();
            button_Valider = new Button();
            button_Retour = new Button();
            comboBox_Dechet = new ComboBox();
            textBox_Prenom = new TextBox();
            textBox_Nom = new TextBox();
            textBox_entreprise = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label_Prénom
            // 
            label_Prénom.AutoSize = true;
            label_Prénom.Location = new Point(42, 48);
            label_Prénom.Name = "label_Prénom";
            label_Prénom.Size = new Size(49, 15);
            label_Prénom.TabIndex = 0;
            label_Prénom.Text = "Prénom";
            // 
            // label_Nom
            // 
            label_Nom.AutoSize = true;
            label_Nom.Location = new Point(274, 47);
            label_Nom.Name = "label_Nom";
            label_Nom.Size = new Size(34, 15);
            label_Nom.TabIndex = 1;
            label_Nom.Text = "Nom";
            // 
            // label_entreprise
            // 
            label_entreprise.AutoSize = true;
            label_entreprise.Location = new Point(42, 171);
            label_entreprise.Name = "label_entreprise";
            label_entreprise.Size = new Size(111, 15);
            label_entreprise.TabIndex = 2;
            label_entreprise.Text = "Nom de l'entreprise";
            // 
            // label_Immatriculation
            // 
            label_Immatriculation.AutoSize = true;
            label_Immatriculation.Location = new Point(270, 171);
            label_Immatriculation.Name = "label_Immatriculation";
            label_Immatriculation.Size = new Size(141, 15);
            label_Immatriculation.TabIndex = 3;
            label_Immatriculation.Text = "Plaque d'immatriculation";
            // 
            // label_dechet
            // 
            label_dechet.AutoSize = true;
            label_dechet.Location = new Point(42, 248);
            label_dechet.Name = "label_dechet";
            label_dechet.Size = new Size(87, 15);
            label_dechet.TabIndex = 4;
            label_dechet.Text = "Type de déchet";
            // 
            // label_prix
            // 
            label_prix.AutoSize = true;
            label_prix.Location = new Point(42, 272);
            label_prix.Name = "label_prix";
            label_prix.Size = new Size(168, 15);
            label_prix.TabIndex = 5;
            label_prix.Text = "Prix de 10 euros TTC les 100 KG";
            // 
            // button_Valider
            // 
            button_Valider.Location = new Point(670, 380);
            button_Valider.Name = "button_Valider";
            button_Valider.Size = new Size(100, 40);
            button_Valider.TabIndex = 6;
            button_Valider.Text = "Valider";
            button_Valider.UseVisualStyleBackColor = true;
            // 
            // button_Retour
            // 
            button_Retour.Location = new Point(30, 380);
            button_Retour.Name = "button_Retour";
            button_Retour.Size = new Size(100, 40);
            button_Retour.TabIndex = 7;
            button_Retour.Text = "Retour";
            button_Retour.UseVisualStyleBackColor = true;
            // 
            // comboBox_Dechet
            // 
            comboBox_Dechet.FormattingEnabled = true;
            comboBox_Dechet.Location = new Point(42, 290);
            comboBox_Dechet.Name = "comboBox_Dechet";
            comboBox_Dechet.Size = new Size(220, 23);
            comboBox_Dechet.TabIndex = 8;
            comboBox_Dechet.Text = "Sélectionner votre type de déchet";
            // 
            // textBox_Prenom
            // 
            textBox_Prenom.Location = new Point(42, 66);
            textBox_Prenom.Name = "textBox_Prenom";
            textBox_Prenom.Size = new Size(138, 23);
            textBox_Prenom.TabIndex = 9;
            textBox_Prenom.Text = "Votre Prénom";
            // 
            // textBox_Nom
            // 
            textBox_Nom.Location = new Point(270, 66);
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.Size = new Size(131, 23);
            textBox_Nom.TabIndex = 10;
            textBox_Nom.Text = "Votre Nom";
            // 
            // textBox_entreprise
            // 
            textBox_entreprise.Location = new Point(42, 189);
            textBox_entreprise.Name = "textBox_entreprise";
            textBox_entreprise.Size = new Size(174, 23);
            textBox_entreprise.TabIndex = 11;
            textBox_entreprise.Text = V;
            textBox_entreprise.TextChanged += this.textBox_entreprise_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 12;
            textBox1.Text = "Ex : AB123CD";
            // 
            // Form_Enregistrement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(textBox_entreprise);
            Controls.Add(textBox_Nom);
            Controls.Add(textBox_Prenom);
            Controls.Add(comboBox_Dechet);
            Controls.Add(button_Retour);
            Controls.Add(button_Valider);
            Controls.Add(label_prix);
            Controls.Add(label_dechet);
            Controls.Add(label_Immatriculation);
            Controls.Add(label_entreprise);
            Controls.Add(label_Nom);
            Controls.Add(label_Prénom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Enregistrement";
            Text = "Enregistrement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Prénom;
        private Label label_Nom;
        private Label label_entreprise;
        private Label label_Immatriculation;
        private Label label_dechet;
        private Label label_prix;
        private Button button_Valider;
        private Button button_Retour;
        private ComboBox comboBox_Dechet;
        private TextBox textBox_Prenom;
        private TextBox textBox_Nom;
        private TextBox textBox_entreprise;
        private TextBox textBox1;
    }
}