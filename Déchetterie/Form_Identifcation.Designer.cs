namespace Déchetterie
{
    partial class Form_Identifcation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Identifcation));
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
            label_Identification.AutoSize = true;
            label_Identification.Location = new Point(332, 83);
            label_Identification.Name = "label_Identification";
            label_Identification.Size = new Size(141, 15);
            label_Identification.TabIndex = 0;
            label_Identification.Text = "Identification du véhicule";
            // 
            // label_soustitre_identification
            // 
            label_soustitre_identification.AutoSize = true;
            label_soustitre_identification.Location = new Point(271, 120);
            label_soustitre_identification.Name = "label_soustitre_identification";
            label_soustitre_identification.Size = new Size(261, 15);
            label_soustitre_identification.TabIndex = 1;
            label_soustitre_identification.Text = "Veuillez entrer les informations de votre véhicule";
            // 
            // label_plaqueimmatriculation
            // 
            label_plaqueimmatriculation.AutoSize = true;
            label_plaqueimmatriculation.Location = new Point(271, 208);
            label_plaqueimmatriculation.Name = "label_plaqueimmatriculation";
            label_plaqueimmatriculation.Size = new Size(141, 15);
            label_plaqueimmatriculation.TabIndex = 2;
            label_plaqueimmatriculation.Text = "Plaque d'immatriculation";
            // 
            // textBox_immatriculation
            // 
            textBox_immatriculation.Location = new Point(271, 235);
            textBox_immatriculation.Name = "textBox_immatriculation";
            textBox_immatriculation.Size = new Size(204, 23);
            textBox_immatriculation.TabIndex = 3;
            textBox_immatriculation.Text = "Ex : AB123CD";
            // 
            // button_Retour
            // 
            button_Retour.Location = new Point(30, 380);
            button_Retour.Name = "button_Retour";
            button_Retour.Size = new Size(100, 40);
            button_Retour.TabIndex = 4;
            button_Retour.Text = "Retour";
            button_Retour.UseVisualStyleBackColor = true;
            // 
            // button_Valider
            // 
            button_Valider.Location = new Point(670, 380);
            button_Valider.Name = "button_Valider";
            button_Valider.Size = new Size(100, 40);
            button_Valider.TabIndex = 5;
            button_Valider.Text = "Valider";
            button_Valider.UseVisualStyleBackColor = true;
            // 
            // Form_Identifcation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Valider);
            Controls.Add(button_Retour);
            Controls.Add(textBox_immatriculation);
            Controls.Add(label_plaqueimmatriculation);
            Controls.Add(label_soustitre_identification);
            Controls.Add(label_Identification);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Identifcation";
            Text = "Identification";
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