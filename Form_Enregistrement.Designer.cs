
using System.ComponentModel;
using System.Text.RegularExpressions;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form_Enregistrement));
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
            textBox_immatriculation = new TextBox();
            SuspendLayout();
            // 
            // label_Prénom
            // 
            label_Prénom.AutoSize = true;
            label_Prénom.Font = new Font("Segoe UI", 19F);
            label_Prénom.Location = new Point(42, 48);
            label_Prénom.Name = "label_Prénom";
            label_Prénom.Size = new Size(105, 36);
            label_Prénom.TabIndex = 0;
            label_Prénom.Text = "Prénom";
            // 
            // label_Nom
            // 
            label_Nom.AutoSize = true;
            label_Nom.Font = new Font("Segoe UI", 19F);
            label_Nom.Location = new Point(333, 48);
            label_Nom.Name = "label_Nom";
            label_Nom.Size = new Size(71, 36);
            label_Nom.TabIndex = 1;
            label_Nom.Text = "Nom";
            label_Nom.Click += label_Nom_Click;
            // 
            // label_entreprise
            // 
            label_entreprise.AutoSize = true;
            label_entreprise.Font = new Font("Segoe UI", 19F);
            label_entreprise.Location = new Point(42, 198);
            label_entreprise.Name = "label_entreprise";
            label_entreprise.Size = new Size(242, 36);
            label_entreprise.TabIndex = 2;
            label_entreprise.Text = "Nom de l'entreprise";
            // 
            // label_Immatriculation
            // 
            label_Immatriculation.AutoSize = true;
            label_Immatriculation.Font = new Font("Segoe UI", 19F);
            label_Immatriculation.Location = new Point(42, 352);
            label_Immatriculation.Name = "label_Immatriculation";
            label_Immatriculation.Size = new Size(299, 36);
            label_Immatriculation.TabIndex = 3;
            label_Immatriculation.Text = "Plaque d'immatriculation";
            // 
            // label_dechet
            // 
            label_dechet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_dechet.AutoSize = true;
            label_dechet.Font = new Font("Segoe UI", 19F);
            label_dechet.Location = new Point(42, 497);
            label_dechet.Name = "label_dechet";
            label_dechet.Size = new Size(192, 36);
            label_dechet.TabIndex = 4;
            label_dechet.Text = "Type de déchet";
            // 
            // label_prix
            // 
            label_prix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_prix.AutoSize = true;
            label_prix.Font = new Font("Segoe UI", 19F);
            label_prix.Location = new Point(42, 533);
            label_prix.Name = "label_prix";
            label_prix.Size = new Size(376, 36);
            label_prix.TabIndex = 5;
            label_prix.Text = "Prix de 10 euros TTC les 100 KG";
            label_prix.Click += label_prix_Click;
            // 
            // button_Valider
            // 
            button_Valider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Valider.Font = new Font("Segoe UI", 19F);
            button_Valider.Location = new Point(1558, 847);
            button_Valider.Name = "button_Valider";
            button_Valider.Size = new Size(300, 115);
            button_Valider.TabIndex = 6;
            button_Valider.Text = "Valider";
            button_Valider.UseVisualStyleBackColor = true;
            button_Valider.Click += button_Valider_Click;
            // 
            // button_Retour
            // 
            button_Retour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Retour.Font = new Font("Segoe UI", 19F);
            button_Retour.Location = new Point(42, 847);
            button_Retour.Name = "button_Retour";
            button_Retour.Size = new Size(300, 115);
            button_Retour.TabIndex = 7;
            button_Retour.Text = "Retour";
            button_Retour.UseVisualStyleBackColor = true;
            button_Retour.Click += button_Retour_Click;
            // 
            // comboBox_Dechet
            // 
            comboBox_Dechet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Dechet.Font = new Font("Segoe UI", 19F);
            comboBox_Dechet.FormattingEnabled = true;
            comboBox_Dechet.ItemHeight = 35;
            comboBox_Dechet.Items.AddRange(new object[] { "Déchets verts", "Encombrants             ", "Gravats", "Dechets menagers recyclables", "Dechets dangereux", "Tout venant" });
            comboBox_Dechet.Location = new Point(42, 572);
            comboBox_Dechet.Name = "comboBox_Dechet";
            comboBox_Dechet.Size = new Size(600, 43);
            comboBox_Dechet.TabIndex = 8;
            comboBox_Dechet.Text = "Sélectionner votre type de déchet";
            comboBox_Dechet.SelectedIndexChanged += comboBox_Dechet_SelectedIndexChanged;
            // 
            // textBox_Prenom
            // 
            textBox_Prenom.Font = new Font("Segoe UI", 19F);
            textBox_Prenom.Location = new Point(42, 87);
            textBox_Prenom.Name = "textBox_Prenom";
            textBox_Prenom.Size = new Size(250, 41);
            textBox_Prenom.TabIndex = 9;
            textBox_Prenom.TextChanged += textBox_Prenom_TextChanged;
            // 
            // textBox_Nom
            // 
            textBox_Nom.Font = new Font("Segoe UI", 19F);
            textBox_Nom.Location = new Point(333, 87);
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.Size = new Size(250, 41);
            textBox_Nom.TabIndex = 10;
            textBox_Nom.TextChanged += textBox_Nom_TextChanged;
            // 
            // textBox_entreprise
            // 
            textBox_entreprise.Font = new Font("Segoe UI", 19F);
            textBox_entreprise.Location = new Point(42, 237);
            textBox_entreprise.Name = "textBox_entreprise";
            textBox_entreprise.Size = new Size(500, 41);
            textBox_entreprise.TabIndex = 11;
            textBox_entreprise.TextChanged += textBox_entreprise_TextChanged;
            // 
            // textBox_immatriculation
            // 
            textBox_immatriculation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_immatriculation.Font = new Font("Segoe UI", 19F);
            textBox_immatriculation.Location = new Point(42, 391);
            textBox_immatriculation.Name = "textBox_immatriculation";
            textBox_immatriculation.Size = new Size(400, 41);
            textBox_immatriculation.TabIndex = 12;
            textBox_immatriculation.Tag = "";
            textBox_immatriculation.TextChanged += textBox_immatriculation_TextChanged;
            // 
            // Form_Enregistrement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(textBox_immatriculation);
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
            Load += Form_Enregistrement_Load;
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
        private TextBox textBox_immatriculation;
    }
}