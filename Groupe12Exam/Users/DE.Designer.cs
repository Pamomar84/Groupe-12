namespace Groupe12Exam
{
    partial class DE
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_delete_classe = new System.Windows.Forms.Button();
            this.bt_update_classe = new System.Windows.Forms.Button();
            this.class_assoc_cours = new System.Windows.Forms.LinkLabel();
            this.bt_add_classe = new System.Windows.Forms.Button();
            this.dgv_class = new System.Windows.Forms.DataGridView();
            this.tb_nom_class = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bt_delete_cours = new System.Windows.Forms.Button();
            this.bt_update_cours = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.rtb_cours = new System.Windows.Forms.RichTextBox();
            this.bt_add_cours = new System.Windows.Forms.Button();
            this.dgv_cours = new System.Windows.Forms.DataGridView();
            this.tb_nom_cours = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bt_delete_prof = new System.Windows.Forms.Button();
            this.bt_update_prof = new System.Windows.Forms.Button();
            this.tb_nom_prof = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.dgv_prof = new System.Windows.Forms.DataGridView();
            this.bt_add_prof = new System.Windows.Forms.Button();
            this.tb_tel_prof = new System.Windows.Forms.TextBox();
            this.tb_mail_prof = new System.Windows.Forms.TextBox();
            this.tb_prenom_prof = new System.Windows.Forms.TextBox();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.bt_delete_matiere = new System.Windows.Forms.Button();
            this.bt_update_matiere = new System.Windows.Forms.Button();
            this.bt_add_matiere = new System.Windows.Forms.Button();
            this.dgv_matiere = new System.Windows.Forms.DataGridView();
            this.tb_matiere = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.class_assoc_matiere = new System.Windows.Forms.LinkLabel();
            this.class_assoc_prof = new System.Windows.Forms.LinkLabel();
            this.class_assoc_etudiants = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cours)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prof)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matiere)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(-4, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1057, 611);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_delete_classe);
            this.tabPage2.Controls.Add(this.bt_update_classe);
            this.tabPage2.Controls.Add(this.class_assoc_cours);
            this.tabPage2.Controls.Add(this.class_assoc_matiere);
            this.tabPage2.Controls.Add(this.class_assoc_prof);
            this.tabPage2.Controls.Add(this.class_assoc_etudiants);
            this.tabPage2.Controls.Add(this.bt_add_classe);
            this.tabPage2.Controls.Add(this.dgv_class);
            this.tabPage2.Controls.Add(this.tb_nom_class);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1049, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_delete_classe
            // 
            this.bt_delete_classe.Location = new System.Drawing.Point(706, 32);
            this.bt_delete_classe.Name = "bt_delete_classe";
            this.bt_delete_classe.Size = new System.Drawing.Size(151, 42);
            this.bt_delete_classe.TabIndex = 9;
            this.bt_delete_classe.Text = "Delete";
            this.bt_delete_classe.UseVisualStyleBackColor = true;
            this.bt_delete_classe.Click += new System.EventHandler(this.bt_delete_classe_Click);
            // 
            // bt_update_classe
            // 
            this.bt_update_classe.Location = new System.Drawing.Point(549, 32);
            this.bt_update_classe.Name = "bt_update_classe";
            this.bt_update_classe.Size = new System.Drawing.Size(151, 42);
            this.bt_update_classe.TabIndex = 8;
            this.bt_update_classe.Text = "Update";
            this.bt_update_classe.UseVisualStyleBackColor = true;
            this.bt_update_classe.Click += new System.EventHandler(this.bt_update_classe_Click);
            // 
            // class_assoc_cours
            // 
            this.class_assoc_cours.AutoSize = true;
            this.class_assoc_cours.Location = new System.Drawing.Point(9, 360);
            this.class_assoc_cours.Name = "class_assoc_cours";
            this.class_assoc_cours.Size = new System.Drawing.Size(113, 20);
            this.class_assoc_cours.TabIndex = 7;
            this.class_assoc_cours.TabStop = true;
            this.class_assoc_cours.Text = "Associer cours";
            this.class_assoc_cours.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.class_assoc_cours_LinkClicked);
            // 
            // bt_add_classe
            // 
            this.bt_add_classe.Location = new System.Drawing.Point(393, 32);
            this.bt_add_classe.Name = "bt_add_classe";
            this.bt_add_classe.Size = new System.Drawing.Size(151, 42);
            this.bt_add_classe.TabIndex = 3;
            this.bt_add_classe.Text = "ADD";
            this.bt_add_classe.UseVisualStyleBackColor = true;
            this.bt_add_classe.Click += new System.EventHandler(this.bt_add_classe_Click);
            // 
            // dgv_class
            // 
            this.dgv_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_class.Location = new System.Drawing.Point(173, 93);
            this.dgv_class.Name = "dgv_class";
            this.dgv_class.RowHeadersWidth = 62;
            this.dgv_class.RowTemplate.Height = 28;
            this.dgv_class.Size = new System.Drawing.Size(684, 479);
            this.dgv_class.TabIndex = 2;
            // 
            // tb_nom_class
            // 
            this.tb_nom_class.Location = new System.Drawing.Point(222, 32);
            this.tb_nom_class.Multiline = true;
            this.tb_nom_class.Name = "tb_nom_class";
            this.tb_nom_class.Size = new System.Drawing.Size(165, 42);
            this.tb_nom_class.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nom";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bt_delete_cours);
            this.tabPage3.Controls.Add(this.bt_update_cours);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.rtb_cours);
            this.tabPage3.Controls.Add(this.bt_add_cours);
            this.tabPage3.Controls.Add(this.dgv_cours);
            this.tabPage3.Controls.Add(this.tb_nom_cours);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1049, 578);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bt_delete_cours
            // 
            this.bt_delete_cours.Location = new System.Drawing.Point(21, 460);
            this.bt_delete_cours.Name = "bt_delete_cours";
            this.bt_delete_cours.Size = new System.Drawing.Size(257, 42);
            this.bt_delete_cours.TabIndex = 15;
            this.bt_delete_cours.Text = "Delete";
            this.bt_delete_cours.UseVisualStyleBackColor = true;
            this.bt_delete_cours.Click += new System.EventHandler(this.bt_delete_cours_Click);
            // 
            // bt_update_cours
            // 
            this.bt_update_cours.Location = new System.Drawing.Point(21, 395);
            this.bt_update_cours.Name = "bt_update_cours";
            this.bt_update_cours.Size = new System.Drawing.Size(257, 42);
            this.bt_update_cours.TabIndex = 14;
            this.bt_update_cours.Text = "Update";
            this.bt_update_cours.UseVisualStyleBackColor = true;
            this.bt_update_cours.Click += new System.EventHandler(this.bt_update_cours_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "Description";
            // 
            // rtb_cours
            // 
            this.rtb_cours.Location = new System.Drawing.Point(21, 206);
            this.rtb_cours.Name = "rtb_cours";
            this.rtb_cours.Size = new System.Drawing.Size(259, 96);
            this.rtb_cours.TabIndex = 12;
            this.rtb_cours.Text = "";
            // 
            // bt_add_cours
            // 
            this.bt_add_cours.Location = new System.Drawing.Point(21, 331);
            this.bt_add_cours.Name = "bt_add_cours";
            this.bt_add_cours.Size = new System.Drawing.Size(257, 42);
            this.bt_add_cours.TabIndex = 11;
            this.bt_add_cours.Text = "ADD";
            this.bt_add_cours.UseVisualStyleBackColor = true;
            this.bt_add_cours.Click += new System.EventHandler(this.bt_add_cours_Click);
            // 
            // dgv_cours
            // 
            this.dgv_cours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cours.Location = new System.Drawing.Point(301, 49);
            this.dgv_cours.Name = "dgv_cours";
            this.dgv_cours.RowHeadersWidth = 62;
            this.dgv_cours.RowTemplate.Height = 28;
            this.dgv_cours.Size = new System.Drawing.Size(684, 512);
            this.dgv_cours.TabIndex = 10;
            // 
            // tb_nom_cours
            // 
            this.tb_nom_cours.Location = new System.Drawing.Point(67, 87);
            this.tb_nom_cours.Multiline = true;
            this.tb_nom_cours.Name = "tb_nom_cours";
            this.tb_nom_cours.Size = new System.Drawing.Size(213, 42);
            this.tb_nom_cours.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Nom";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bt_delete_prof);
            this.tabPage4.Controls.Add(this.bt_update_prof);
            this.tabPage4.Controls.Add(this.tb_nom_prof);
            this.tabPage4.Controls.Add(this.l1);
            this.tabPage4.Controls.Add(this.dgv_prof);
            this.tabPage4.Controls.Add(this.bt_add_prof);
            this.tabPage4.Controls.Add(this.tb_tel_prof);
            this.tabPage4.Controls.Add(this.tb_mail_prof);
            this.tabPage4.Controls.Add(this.tb_prenom_prof);
            this.tabPage4.Controls.Add(this.l4);
            this.tabPage4.Controls.Add(this.l3);
            this.tabPage4.Controls.Add(this.l2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1049, 578);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bt_delete_prof
            // 
            this.bt_delete_prof.Location = new System.Drawing.Point(85, 501);
            this.bt_delete_prof.Name = "bt_delete_prof";
            this.bt_delete_prof.Size = new System.Drawing.Size(215, 53);
            this.bt_delete_prof.TabIndex = 38;
            this.bt_delete_prof.Text = "Delete";
            this.bt_delete_prof.UseVisualStyleBackColor = true;
            this.bt_delete_prof.Click += new System.EventHandler(this.bt_delete_prof_Click);
            // 
            // bt_update_prof
            // 
            this.bt_update_prof.Location = new System.Drawing.Point(85, 438);
            this.bt_update_prof.Name = "bt_update_prof";
            this.bt_update_prof.Size = new System.Drawing.Size(215, 53);
            this.bt_update_prof.TabIndex = 37;
            this.bt_update_prof.Text = "Update";
            this.bt_update_prof.UseVisualStyleBackColor = true;
            this.bt_update_prof.Click += new System.EventHandler(this.bt_update_prof_Click);
            // 
            // tb_nom_prof
            // 
            this.tb_nom_prof.Location = new System.Drawing.Point(85, 95);
            this.tb_nom_prof.Multiline = true;
            this.tb_nom_prof.Name = "tb_nom_prof";
            this.tb_nom_prof.Size = new System.Drawing.Size(215, 40);
            this.tb_nom_prof.TabIndex = 36;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(27, 98);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(42, 20);
            this.l1.TabIndex = 35;
            this.l1.Text = "Nom";
            // 
            // dgv_prof
            // 
            this.dgv_prof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prof.Location = new System.Drawing.Point(335, 26);
            this.dgv_prof.Name = "dgv_prof";
            this.dgv_prof.RowHeadersWidth = 62;
            this.dgv_prof.RowTemplate.Height = 28;
            this.dgv_prof.Size = new System.Drawing.Size(684, 512);
            this.dgv_prof.TabIndex = 34;
            // 
            // bt_add_prof
            // 
            this.bt_add_prof.Location = new System.Drawing.Point(85, 379);
            this.bt_add_prof.Name = "bt_add_prof";
            this.bt_add_prof.Size = new System.Drawing.Size(215, 53);
            this.bt_add_prof.TabIndex = 33;
            this.bt_add_prof.Text = "Add";
            this.bt_add_prof.UseVisualStyleBackColor = true;
            this.bt_add_prof.Click += new System.EventHandler(this.bt_add_prof_Click);
            // 
            // tb_tel_prof
            // 
            this.tb_tel_prof.Location = new System.Drawing.Point(85, 320);
            this.tb_tel_prof.Multiline = true;
            this.tb_tel_prof.Name = "tb_tel_prof";
            this.tb_tel_prof.Size = new System.Drawing.Size(215, 36);
            this.tb_tel_prof.TabIndex = 32;
            // 
            // tb_mail_prof
            // 
            this.tb_mail_prof.Location = new System.Drawing.Point(85, 245);
            this.tb_mail_prof.Multiline = true;
            this.tb_mail_prof.Name = "tb_mail_prof";
            this.tb_mail_prof.Size = new System.Drawing.Size(215, 42);
            this.tb_mail_prof.TabIndex = 31;
            // 
            // tb_prenom_prof
            // 
            this.tb_prenom_prof.Location = new System.Drawing.Point(85, 174);
            this.tb_prenom_prof.Multiline = true;
            this.tb_prenom_prof.Name = "tb_prenom_prof";
            this.tb_prenom_prof.Size = new System.Drawing.Size(215, 40);
            this.tb_prenom_prof.TabIndex = 30;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(39, 323);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(30, 20);
            this.l4.TabIndex = 29;
            this.l4.Text = "Tel";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(21, 248);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(48, 20);
            this.l3.TabIndex = 28;
            this.l3.Text = "Email";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(15, 177);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(64, 20);
            this.l2.TabIndex = 27;
            this.l2.Text = "Prenom";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.bt_delete_matiere);
            this.tabPage8.Controls.Add(this.bt_update_matiere);
            this.tabPage8.Controls.Add(this.bt_add_matiere);
            this.tabPage8.Controls.Add(this.dgv_matiere);
            this.tabPage8.Controls.Add(this.tb_matiere);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1049, 578);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage4";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // bt_delete_matiere
            // 
            this.bt_delete_matiere.Location = new System.Drawing.Point(746, 27);
            this.bt_delete_matiere.Name = "bt_delete_matiere";
            this.bt_delete_matiere.Size = new System.Drawing.Size(159, 42);
            this.bt_delete_matiere.TabIndex = 9;
            this.bt_delete_matiere.Text = "Delete";
            this.bt_delete_matiere.UseVisualStyleBackColor = true;
            this.bt_delete_matiere.Click += new System.EventHandler(this.bt_delete_matiere_Click);
            // 
            // bt_update_matiere
            // 
            this.bt_update_matiere.Location = new System.Drawing.Point(575, 27);
            this.bt_update_matiere.Name = "bt_update_matiere";
            this.bt_update_matiere.Size = new System.Drawing.Size(165, 42);
            this.bt_update_matiere.TabIndex = 8;
            this.bt_update_matiere.Text = "Update";
            this.bt_update_matiere.UseVisualStyleBackColor = true;
            this.bt_update_matiere.Click += new System.EventHandler(this.bt_update_matiere_Click);
            // 
            // bt_add_matiere
            // 
            this.bt_add_matiere.Location = new System.Drawing.Point(386, 27);
            this.bt_add_matiere.Name = "bt_add_matiere";
            this.bt_add_matiere.Size = new System.Drawing.Size(183, 42);
            this.bt_add_matiere.TabIndex = 7;
            this.bt_add_matiere.Text = "ADD";
            this.bt_add_matiere.UseVisualStyleBackColor = true;
            this.bt_add_matiere.Click += new System.EventHandler(this.bt_add_matiere_Click);
            // 
            // dgv_matiere
            // 
            this.dgv_matiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_matiere.Location = new System.Drawing.Point(221, 91);
            this.dgv_matiere.Name = "dgv_matiere";
            this.dgv_matiere.RowHeadersWidth = 62;
            this.dgv_matiere.RowTemplate.Height = 28;
            this.dgv_matiere.Size = new System.Drawing.Size(684, 512);
            this.dgv_matiere.TabIndex = 6;
            // 
            // tb_matiere
            // 
            this.tb_matiere.Location = new System.Drawing.Point(265, 27);
            this.tb_matiere.Multiline = true;
            this.tb_matiere.Name = "tb_matiere";
            this.tb_matiere.Size = new System.Drawing.Size(115, 42);
            this.tb_matiere.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(217, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Nom";
            // 
            // class_assoc_matiere
            // 
            this.class_assoc_matiere.AutoSize = true;
            this.class_assoc_matiere.Location = new System.Drawing.Point(11, 311);
            this.class_assoc_matiere.Name = "class_assoc_matiere";
            this.class_assoc_matiere.Size = new System.Drawing.Size(127, 20);
            this.class_assoc_matiere.TabIndex = 6;
            this.class_assoc_matiere.TabStop = true;
            this.class_assoc_matiere.Text = "Associer matiere";
            this.class_assoc_matiere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.class_assoc_matiere_LinkClicked);
            // 
            // class_assoc_prof
            // 
            this.class_assoc_prof.AutoSize = true;
            this.class_assoc_prof.Location = new System.Drawing.Point(11, 253);
            this.class_assoc_prof.Name = "class_assoc_prof";
            this.class_assoc_prof.Size = new System.Drawing.Size(158, 20);
            this.class_assoc_prof.TabIndex = 5;
            this.class_assoc_prof.TabStop = true;
            this.class_assoc_prof.Text = "Associer professeurs";
            this.class_assoc_prof.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.class_assoc_prof_LinkClicked);
            // 
            // class_assoc_etudiants
            // 
            this.class_assoc_etudiants.AutoSize = true;
            this.class_assoc_etudiants.Location = new System.Drawing.Point(11, 202);
            this.class_assoc_etudiants.Name = "class_assoc_etudiants";
            this.class_assoc_etudiants.Size = new System.Drawing.Size(140, 20);
            this.class_assoc_etudiants.TabIndex = 4;
            this.class_assoc_etudiants.TabStop = true;
            this.class_assoc_etudiants.Text = "Associer etudiants";
            this.class_assoc_etudiants.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.class_assoc_etudiants_LinkClicked);
            // 
            // DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 624);
            this.Controls.Add(this.tabControl1);
            this.Name = "DE";
            this.Text = "DE";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cours)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prof)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matiere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_delete_classe;
        private System.Windows.Forms.Button bt_update_classe;
        private System.Windows.Forms.LinkLabel class_assoc_cours;
        private System.Windows.Forms.Button bt_add_classe;
        private System.Windows.Forms.DataGridView dgv_class;
        private System.Windows.Forms.TextBox tb_nom_class;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bt_delete_cours;
        private System.Windows.Forms.Button bt_update_cours;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox rtb_cours;
        private System.Windows.Forms.Button bt_add_cours;
        private System.Windows.Forms.DataGridView dgv_cours;
        private System.Windows.Forms.TextBox tb_nom_cours;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button bt_delete_prof;
        private System.Windows.Forms.Button bt_update_prof;
        private System.Windows.Forms.TextBox tb_nom_prof;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.DataGridView dgv_prof;
        private System.Windows.Forms.Button bt_add_prof;
        private System.Windows.Forms.TextBox tb_tel_prof;
        private System.Windows.Forms.TextBox tb_mail_prof;
        private System.Windows.Forms.TextBox tb_prenom_prof;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button bt_delete_matiere;
        private System.Windows.Forms.Button bt_update_matiere;
        private System.Windows.Forms.Button bt_add_matiere;
        private System.Windows.Forms.DataGridView dgv_matiere;
        private System.Windows.Forms.TextBox tb_matiere;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel class_assoc_matiere;
        private System.Windows.Forms.LinkLabel class_assoc_prof;
        private System.Windows.Forms.LinkLabel class_assoc_etudiants;
    }
}