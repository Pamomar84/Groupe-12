namespace p4_gf.admin.classes
{
    partial class ClasseAssocCours
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
            this.bt_classe_assoc_cours = new System.Windows.Forms.Button();
            this.lb_classe_assoc_cours = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_classe_assoc_cours
            // 
            this.bt_classe_assoc_cours.Location = new System.Drawing.Point(96, 419);
            this.bt_classe_assoc_cours.Name = "bt_classe_assoc_cours";
            this.bt_classe_assoc_cours.Size = new System.Drawing.Size(198, 49);
            this.bt_classe_assoc_cours.TabIndex = 7;
            this.bt_classe_assoc_cours.Text = "Associer";
            this.bt_classe_assoc_cours.UseVisualStyleBackColor = true;
            this.bt_classe_assoc_cours.Click += new System.EventHandler(this.bt_classe_assoc_cours_Click);
            // 
            // lb_classe_assoc_cours
            // 
            this.lb_classe_assoc_cours.FormattingEnabled = true;
            this.lb_classe_assoc_cours.ItemHeight = 20;
            this.lb_classe_assoc_cours.Location = new System.Drawing.Point(96, 25);
            this.lb_classe_assoc_cours.Name = "lb_classe_assoc_cours";
            this.lb_classe_assoc_cours.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_classe_assoc_cours.Size = new System.Drawing.Size(198, 364);
            this.lb_classe_assoc_cours.TabIndex = 6;
            // 
            // ClasseAssocCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 493);
            this.Controls.Add(this.bt_classe_assoc_cours);
            this.Controls.Add(this.lb_classe_assoc_cours);
            this.Name = "ClasseAssocCours";
            this.Text = "ClasseAssocCours";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_classe_assoc_cours;
        private System.Windows.Forms.ListBox lb_classe_assoc_cours;
    }
}