namespace Déchetterie
{
    partial class Form_Identification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Identification));
            label_Identification = new Label();
            label_soustitre_identification = new Label();
            label_plaqueimmatriculation = new Label();
            textBox_immatriculation = new TextBox();
            button_Retour = new Button();
            button_Valider = new Button();
            SuspendLayout();
            // 
            // label_Identification
            // 
            label_Identification.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Identification.AutoSize = true;
            label_Identification.Font = new Font("Segoe UI", 19F);
            label_Identification.Location = new Point(800, 113);
            label_Identification.Name = "label_Identification";
            label_Identification.Size = new Size(303, 36);
            label_Identification.TabIndex = 0;
            label_Identification.Text = "Identification du véhicule";
            // 
            // label_soustitre_identification
            // 
            label_soustitre_identification.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_soustitre_identification.AutoSize = true;
            label_soustitre_identification.Font = new Font("Segoe UI", 19F);
            label_soustitre_identification.Location = new Point(671, 149);
            label_soustitre_identification.Name = "label_soustitre_identification";
            label_soustitre_identification.Size = new Size(571, 36);
            label_soustitre_identification.TabIndex = 1;
            label_soustitre_identification.Text = "Veuillez entrer les informations de votre véhicule";
            // 
            // label_plaqueimmatriculation
            // 
            label_plaqueimmatriculation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_plaqueimmatriculation.AutoSize = true;
            label_plaqueimmatriculation.Font = new Font("Segoe UI", 19F);
            label_plaqueimmatriculation.Location = new Point(660, 266);
            label_plaqueimmatriculation.Name = "label_plaqueimmatriculation";
            label_plaqueimmatriculation.Size = new Size(299, 36);
            label_plaqueimmatriculation.TabIndex = 2;
            label_plaqueimmatriculation.Text = "Plaque d'immatriculation";
            label_plaqueimmatriculation.Click += label_plaqueimmatriculation_Click;
            // 
            // textBox_immatriculation
            // 
            textBox_immatriculation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_immatriculation.Font = new Font("Segoe UI", 19F);
            textBox_immatriculation.Location = new Point(660, 305);
            textBox_immatriculation.Name = "textBox_immatriculation";
            textBox_immatriculation.Size = new Size(600, 41);
            textBox_immatriculation.TabIndex = 3;
            textBox_immatriculation.Text = "Ex : AB123CD";
            // 
            // button_Retour
            // 
            button_Retour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Retour.Font = new Font("Segoe UI", 19F);
            button_Retour.Location = new Point(42, 847);
            button_Retour.Name = "button_Retour";
            button_Retour.Size = new Size(300, 115);
            button_Retour.TabIndex = 4;
            button_Retour.Text = "Retour";
            button_Retour.UseVisualStyleBackColor = true;
            button_Retour.Click += button_Retour_Click;
            // 
            // button_Valider
            // 
            button_Valider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Valider.Font = new Font("Segoe UI", 19F);
            button_Valider.Location = new Point(1558, 847);
            button_Valider.Name = "button_Valider";
            button_Valider.Size = new Size(300, 115);
            button_Valider.TabIndex = 5;
            button_Valider.Text = "Valider";
            button_Valider.UseVisualStyleBackColor = true;
            button_Valider.Click += button_Valider_Click;
            // 
            // Form_Identification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(button_Valider);
            Controls.Add(button_Retour);
            Controls.Add(textBox_immatriculation);
            Controls.Add(label_plaqueimmatriculation);
            Controls.Add(label_soustitre_identification);
            Controls.Add(label_Identification);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Identification";
            Text = "Identification";
            Load += Form_Identification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Identification;
        private Label label_soustitre_identification;
        private Label label_plaqueimmatriculation;
        private TextBox textBox_immatriculation;
        private Button button_Retour;
        private Button button_Valider;
    }
}