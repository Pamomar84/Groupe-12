namespace p4_gf.admin.classes
{
    partial class ClasseAssocEtudiant
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
            this.lb_classe_assoc_etudiant = new System.Windows.Forms.ListBox();
            this.bt_classe_assoc_etudiant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_classe_assoc_etudiant
            // 
            this.lb_classe_assoc_etudiant.FormattingEnabled = true;
            this.lb_classe_assoc_etudiant.ItemHeight = 20;
            this.lb_classe_assoc_etudiant.Location = new System.Drawing.Point(96, 38);
            this.lb_classe_assoc_etudiant.Name = "lb_classe_assoc_etudiant";
            this.lb_classe_assoc_etudiant.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_classe_assoc_etudiant.Size = new System.Drawing.Size(198, 364);
            this.lb_classe_assoc_etudiant.TabIndex = 0;
            // 
            // bt_classe_assoc_etudiant
            // 
            this.bt_classe_assoc_etudiant.Location = new System.Drawing.Point(96, 432);
            this.bt_classe_assoc_etudiant.Name = "bt_classe_assoc_etudiant";
            this.bt_classe_assoc_etudiant.Size = new System.Drawing.Size(198, 49);
            this.bt_classe_assoc_etudiant.TabIndex = 1;
            this.bt_classe_assoc_etudiant.Text = "Associer";
            this.bt_classe_assoc_etudiant.UseVisualStyleBackColor = true;
            this.bt_classe_assoc_etudiant.Click += new System.EventHandler(this.bt_classe_assoc_etudiant_Click);
            // 
            // ClasseAssocEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 493);
            this.Controls.Add(this.bt_classe_assoc_etudiant);
            this.Controls.Add(this.lb_classe_assoc_etudiant);
            this.Name = "ClasseAssocEtudiant";
            this.Text = "ClasseAssocEtudiant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_classe_assoc_etudiant;
        private System.Windows.Forms.Button bt_classe_assoc_etudiant;
    }
}