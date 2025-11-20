namespace Déchetterie
{
    partial class Form_acceuil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_acceuil));
            label1 = new Label();
            label2 = new Label();
            btn_Enregistrement = new Button();
            btn_identification = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 138);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "La Déchetteri CIEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 183);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 1;
            label2.Text = "Vous souhaite la bienvenue";
            // 
            // btn_Enregistrement
            // 
            btn_Enregistrement.Location = new Point(306, 235);
            btn_Enregistrement.Name = "btn_Enregistrement";
            btn_Enregistrement.Size = new Size(165, 50);
            btn_Enregistrement.TabIndex = 2;
            btn_Enregistrement.Text = "Enregistrement";
            btn_Enregistrement.UseVisualStyleBackColor = true;
            btn_Enregistrement.Click += btn_Enregistrement_Click;
            // 
            // btn_identification
            // 
            btn_identification.Location = new Point(304, 317);
            btn_identification.Name = "btn_identification";
            btn_identification.Size = new Size(165, 50);
            btn_identification.TabIndex = 3;
            btn_identification.Text = "Identification";
            btn_identification.UseVisualStyleBackColor = true;
            // 
            // Form_acceuil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 442);
            Controls.Add(btn_identification);
            Controls.Add(btn_Enregistrement);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_acceuil";
            Text = "Déchetterie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_Enregistrement;
        private Button btn_identification;
    }
}
