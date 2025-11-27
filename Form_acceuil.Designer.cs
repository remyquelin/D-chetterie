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
            btn_Identification = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(840, 150);
            label1.Name = "label1";
            label1.Size = new Size(222, 36);
            label1.TabIndex = 0;
            label1.Text = "La Déchetteri CIEL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F);
            label2.Location = new Point(800, 200);
            label2.Name = "label2";
            label2.Size = new Size(328, 36);
            label2.TabIndex = 1;
            label2.Text = "Vous souhaite la bienvenue";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Enregistrement
            // 
            btn_Enregistrement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Enregistrement.Font = new Font("Segoe UI", 19F);
            btn_Enregistrement.Location = new Point(660, 300);
            btn_Enregistrement.Name = "btn_Enregistrement";
            btn_Enregistrement.RightToLeft = RightToLeft.No;
            btn_Enregistrement.Size = new Size(600, 110);
            btn_Enregistrement.TabIndex = 2;
            btn_Enregistrement.Text = "Enregistrement";
            btn_Enregistrement.UseVisualStyleBackColor = true;
            btn_Enregistrement.Click += btn_Enregistrement_Click;
            // 
            // btn_Identification
            // 
            btn_Identification.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Identification.Font = new Font("Segoe UI", 19F);
            btn_Identification.Location = new Point(660, 490);
            btn_Identification.Name = "btn_Identification";
            btn_Identification.Size = new Size(600, 110);
            btn_Identification.TabIndex = 3;
            btn_Identification.Text = "Identification";
            btn_Identification.UseVisualStyleBackColor = true;
            btn_Identification.Click += btn_Identification_Click;
            // 
            // Form_acceuil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btn_Identification);
            Controls.Add(btn_Enregistrement);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_acceuil";
            Text = "Déchetterie";
            Load += Form_acceuil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_Enregistrement;
        private Button btn_Identification;
    }
}
