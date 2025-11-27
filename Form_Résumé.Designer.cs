namespace Déchetterie
{
    partial class Form_Résumé
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Résumé));
            label_titre_tiket = new Label();
            label_sous_titre_ticket = new Label();
            button_Retour = new Button();
            label_InfoConducteur = new Label();
            label_Nom_Prenom = new Label();
            btn_Imprimer = new Button();
            labelPlaque = new Label();
            labelPrix = new Label();
            labelPoids1 = new Label();
            labelPoids2 = new Label();
            labelPoidsnet = new Label();
            labelEntreprise = new Label();
            labelDechet = new Label();
            labelHorodatage = new Label();
            SuspendLayout();
            // 
            // label_titre_tiket
            // 
            label_titre_tiket.AutoSize = true;
            label_titre_tiket.Font = new Font("Segoe UI", 19F);
            label_titre_tiket.ImageAlign = ContentAlignment.TopCenter;
            label_titre_tiket.Location = new Point(879, 37);
            label_titre_tiket.Name = "label_titre_tiket";
            label_titre_tiket.Size = new Size(193, 36);
            label_titre_tiket.TabIndex = 0;
            label_titre_tiket.Text = "Ticket de Pesée";
            // 
            // label_sous_titre_ticket
            // 
            label_sous_titre_ticket.AutoSize = true;
            label_sous_titre_ticket.Font = new Font("Segoe UI", 19F);
            label_sous_titre_ticket.Location = new Point(879, 73);
            label_sous_titre_ticket.Name = "label_sous_titre_ticket";
            label_sous_titre_ticket.Size = new Size(204, 36);
            label_sous_titre_ticket.TabIndex = 1;
            label_sous_titre_ticket.Text = "Déchetterie CIEL";
            // 
            // button_Retour
            // 
            button_Retour.Font = new Font("Segoe UI", 19F);
            button_Retour.Location = new Point(44, 847);
            button_Retour.Name = "button_Retour";
            button_Retour.Size = new Size(300, 115);
            button_Retour.TabIndex = 2;
            button_Retour.Text = "Retour";
            button_Retour.UseVisualStyleBackColor = true;
            button_Retour.Click += button_Retour_Click;
            // 
            // label_InfoConducteur
            // 
            label_InfoConducteur.AutoSize = true;
            label_InfoConducteur.Font = new Font("Segoe UI", 19F);
            label_InfoConducteur.Location = new Point(813, 109);
            label_InfoConducteur.Name = "label_InfoConducteur";
            label_InfoConducteur.Size = new Size(339, 36);
            label_InfoConducteur.TabIndex = 3;
            label_InfoConducteur.Text = "Informations du Conducteur";
            // 
            // label_Nom_Prenom
            // 
            label_Nom_Prenom.AutoSize = true;
            label_Nom_Prenom.Font = new Font("Segoe UI", 19F);
            label_Nom_Prenom.Location = new Point(111, 234);
            label_Nom_Prenom.Name = "label_Nom_Prenom";
            label_Nom_Prenom.Size = new Size(198, 36);
            label_Nom_Prenom.TabIndex = 4;
            label_Nom_Prenom.Text = "Nom et Prénom";
            label_Nom_Prenom.Click += label_Nom_Prenom_Click;
            // 
            // btn_Imprimer
            // 
            btn_Imprimer.Font = new Font("Segoe UI", 19F);
            btn_Imprimer.Location = new Point(1564, 847);
            btn_Imprimer.Name = "btn_Imprimer";
            btn_Imprimer.Size = new Size(300, 115);
            btn_Imprimer.TabIndex = 5;
            btn_Imprimer.Text = "Imprimer";
            btn_Imprimer.UseVisualStyleBackColor = true;
            btn_Imprimer.Click += btn_Imprimer_Click;
            // 
            // labelPlaque
            // 
            labelPlaque.AutoSize = true;
            labelPlaque.Font = new Font("Segoe UI", 19F);
            labelPlaque.Location = new Point(109, 302);
            labelPlaque.Name = "labelPlaque";
            labelPlaque.Size = new Size(278, 36);
            labelPlaque.TabIndex = 6;
            labelPlaque.Text = "Plaque immatriculation";
            // 
            // labelPrix
            // 
            labelPrix.AutoSize = true;
            labelPrix.Font = new Font("Segoe UI", 19F);
            labelPrix.Location = new Point(111, 369);
            labelPrix.Name = "labelPrix";
            labelPrix.Size = new Size(57, 36);
            labelPrix.TabIndex = 7;
            labelPrix.Text = "Prix";
            // 
            // labelPoids1
            // 
            labelPoids1.AutoSize = true;
            labelPoids1.Font = new Font("Segoe UI", 19F);
            labelPoids1.Location = new Point(113, 435);
            labelPoids1.Name = "labelPoids1";
            labelPoids1.Size = new Size(278, 36);
            labelPoids1.TabIndex = 8;
            labelPoids1.Text = "Poids premier passage ";
            // 
            // labelPoids2
            // 
            labelPoids2.AutoSize = true;
            labelPoids2.Font = new Font("Segoe UI", 19F);
            labelPoids2.Location = new Point(115, 497);
            labelPoids2.Name = "labelPoids2";
            labelPoids2.Size = new Size(264, 36);
            labelPoids2.TabIndex = 9;
            labelPoids2.Text = "Poids second passage";
            // 
            // labelPoidsnet
            // 
            labelPoidsnet.AutoSize = true;
            labelPoidsnet.Font = new Font("Segoe UI", 19F);
            labelPoidsnet.Location = new Point(117, 551);
            labelPoidsnet.Name = "labelPoidsnet";
            labelPoidsnet.Size = new Size(128, 36);
            labelPoidsnet.TabIndex = 10;
            labelPoidsnet.Text = "Poids net ";
            labelPoidsnet.Click += labelPoidsnet_Click;
            // 
            // labelEntreprise
            // 
            labelEntreprise.AutoSize = true;
            labelEntreprise.Font = new Font("Segoe UI", 19F);
            labelEntreprise.Location = new Point(111, 607);
            labelEntreprise.Name = "labelEntreprise";
            labelEntreprise.Size = new Size(242, 36);
            labelEntreprise.TabIndex = 11;
            labelEntreprise.Text = "Nom de l'entreprise";
            // 
            // labelDechet
            // 
            labelDechet.AutoSize = true;
            labelDechet.Font = new Font("Segoe UI", 19F);
            labelDechet.Location = new Point(109, 671);
            labelDechet.Name = "labelDechet";
            labelDechet.Size = new Size(192, 36);
            labelDechet.TabIndex = 12;
            labelDechet.Text = "Type de déchet";
            // 
            // labelHorodatage
            // 
            labelHorodatage.AutoSize = true;
            labelHorodatage.Font = new Font("Segoe UI", 19F);
            labelHorodatage.Location = new Point(115, 728);
            labelHorodatage.Name = "labelHorodatage";
            labelHorodatage.Size = new Size(180, 36);
            labelHorodatage.TabIndex = 13;
            labelHorodatage.Text = "Date et heure ";
            // 
            // Form_Résumé
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelHorodatage);
            Controls.Add(labelDechet);
            Controls.Add(labelEntreprise);
            Controls.Add(labelPoidsnet);
            Controls.Add(labelPoids2);
            Controls.Add(labelPoids1);
            Controls.Add(labelPrix);
            Controls.Add(labelPlaque);
            Controls.Add(btn_Imprimer);
            Controls.Add(label_Nom_Prenom);
            Controls.Add(label_InfoConducteur);
            Controls.Add(button_Retour);
            Controls.Add(label_sous_titre_ticket);
            Controls.Add(label_titre_tiket);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Résumé";
            Text = "Résumé";
            Load += Form_Résumé_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titre_tiket;
        private Label label_sous_titre_ticket;
        private Button button_Retour;
        private Label label_InfoConducteur;
        private Label label_Nom_Prenom;
        private Button btn_Imprimer;
        private Label labelPlaque;
        private Label labelPrix;
        private Label labelPoids1;
        private Label labelPoids2;
        private Label labelPoidsnet;
        private Label labelEntreprise;
        private Label labelDechet;
        private Label labelHorodatage;
    }
}