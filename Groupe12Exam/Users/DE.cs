using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using p4_gf.admin.classes;

namespace Groupe12Exam
{
    public partial class DE : Form
    {
        public DE()
        {
            InitializeComponent();
            tabPage2.Text = "Classes";
            tabPage3.Text = "Cours";
            tabPage4.Text = "Professeurs";
            tabPage8.Text = "Matiere";
            ChargerClasses();
            ChargerCours();
            ChargerProf();
            ChargerMatiere();
        }

        // Classes
        // Ajouter une classe
        private void bt_add_classe_Click(object sender, EventArgs e)
        {
            using (var db = new DbScolaire())
            {
                var c = new Classes
                {
                    NomClasse = tb_nom_class.Text,
                };

                db.TClasses.Add(c);
                db.SaveChanges();  // Enregistre dans la base de données
                ChargerClasses();
                clearClasse();
            }
        }
        // Charger classe
        private void ChargerClasses()
        {
            using (var db = new DbScolaire())
            {
                var classe = db.TClasses
                                 .Select(c => new { c.Id, c.NomClasse })
                                 .ToList();
                dgv_class.DataSource = classe;
            }
        }
        private void clearClasse()
        {
            tb_nom_class?.Clear();
        }
        private void classe(object sender, EventArgs e)
        {
            if (dgv_class.SelectedRows.Count > 0)
            {
                int cId = Convert.ToInt32(dgv_class.SelectedRows[0].Cells["Id"].Value);

                using (var db = new DbScolaire())
                {
                    var c = db.TClasses.FirstOrDefault(u => u.Id == cId);

                    if (c != null)
                    {
                        tb_nom_class.Text = c.NomClasse;
                    }
                }
            }
        }
        private void bt_update_classe_Click(object sender, EventArgs e)
        {
            if (dgv_class.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la classe sélectionnée
                int classeId = Convert.ToInt32(dgv_class.SelectedRows[0].Cells["Id"].Value);  // Assure-toi que la colonne "Id" est bien là

                using (var db = new DbScolaire())
                {
                    // Chercher la classe dans la base de données
                    var classe = db.TClasses.FirstOrDefault(c => c.Id == classeId);

                    if (classe != null)
                    {
                        // Mettre à jour le nom de la classe
                        classe.NomClasse = tb_nom_class.Text;

                        db.SaveChanges();  // Enregistre les modifications dans la base de données

                        ChargerClasses();  // Rafraîchit le DataGridView
                        clearClasse();  // Efface les champs de saisie
                    }
                    else
                    {
                        MessageBox.Show("Classe non trouvée.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe à modifier.");
            }
        }
        private void bt_delete_classe_Click(object sender, EventArgs e)
        {
            if (dgv_class.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la classe à supprimer
                int classeId = Convert.ToInt32(dgv_class.SelectedRows[0].Cells["Id"].Value);

                // Demander une confirmation avant de supprimer
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette classe ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var db = new DbScolaire())
                    {
                        // Chercher la classe dans la base de données
                        var classe = db.TClasses.FirstOrDefault(c => c.Id == classeId);

                        if (classe != null)
                        {
                            // Supprimer la classe de la base de données
                            db.TClasses.Remove(classe);
                            db.SaveChanges();  // Enregistre les modifications

                            // Rafraîchit le DataGridView
                            ChargerClasses();
                            clearClasse();  // Efface les champs de saisie
                        }
                        else
                        {
                            MessageBox.Show("Classe non trouvée.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe à supprimer.");
            }
        }

        // Cours
        // Ajout de cours
        private void bt_add_cours_Click(object sender, EventArgs e)
        {
            using (var db = new DbScolaire())
            {
                var c = new Cours
                {
                    NomCours = tb_nom_cours.Text,
                    Description = rtb_cours.Text,
                };

                db.TCours.Add(c);
                db.SaveChanges();  // Enregistre dans la base de données
                ChargerCours();
                clearCours();
            }
        }
        private void ChargerCours()
        {
            using (var db = new DbScolaire())
            {
                var mat = db.TCours
                                 .Select(c => new { c.Id, c.NomCours, c.Description })
                                 .ToList();
                dgv_cours.DataSource = mat;
            }
        }
        private void clearCours()
        {
            tb_nom_cours?.Clear();
            rtb_cours?.Clear();
        }
        private void dgv_cour(object sender, EventArgs e)
        {
            if (dgv_cours.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du cours sélectionné
                int coursId = Convert.ToInt32(dgv_cours.SelectedRows[0].Cells["Id"].Value);  // Assure-toi que la colonne "Id" est bien présente

                using (var db = new DbScolaire())
                {
                    // Chercher le cours dans la base de données
                    var cours = db.TCours.FirstOrDefault(c => c.Id == coursId);

                    if (cours != null)
                    {
                        // Remplir les champs avec les données du cours sélectionné
                        tb_nom_cours.Text = cours.NomCours;
                        rtb_cours.Text = cours.Description;
                    }
                }
            }
        }

        private void bt_update_cours_Click(object sender, EventArgs e)
        {
            if (dgv_cours.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du cours à modifier
                int coursId = Convert.ToInt32(dgv_cours.SelectedRows[0].Cells["Id"].Value);

                using (var db = new DbScolaire())
                {
                    // Chercher le cours dans la base de données
                    var cours = db.TCours.FirstOrDefault(c => c.Id == coursId);

                    if (cours != null)
                    {
                        // Mettre à jour les informations du cours
                        cours.NomCours = tb_nom_cours.Text;
                        cours.Description = rtb_cours.Text;

                        db.SaveChanges();  // Enregistre les modifications dans la base de données

                        ChargerCours();  // Rafraîchit le DataGridView
                        clearCours();  // Efface les champs de saisie
                    }
                    else
                    {
                        MessageBox.Show("Cours non trouvé.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un cours à modifier.");
            }
        }

        private void bt_delete_cours_Click(object sender, EventArgs e)
        {
            if (dgv_cours.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du cours à supprimer
                int coursId = Convert.ToInt32(dgv_cours.SelectedRows[0].Cells["Id"].Value);

                // Demander une confirmation avant de supprimer
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce cours ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var db = new DbScolaire())
                    {
                        // Chercher le cours dans la base de données
                        var cours = db.TCours.FirstOrDefault(c => c.Id == coursId);

                        if (cours != null)
                        {
                            // Supprimer le cours de la base de données
                            db.TCours.Remove(cours);
                            db.SaveChanges();  // Enregistre la suppression dans la base de données

                            ChargerCours();  // Rafraîchit le DataGridView
                            clearCours();  // Efface les champs de saisie
                        }
                        else
                        {
                            MessageBox.Show("Cours non trouvé.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un cours à supprimer.");
            }
        }

        // Associations
        // Classe - Etudiants
        private void class_assoc_etudiants_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var classeSelectionnee = dgv_class.CurrentRow;

            if (classeSelectionnee != null)
            {
                int idClasse = Convert.ToInt32(classeSelectionnee.Cells["Id"].Value);
                ClasseAssocEtudiant c = new ClasseAssocEtudiant(idClasse);
                c.Show();
            }
        }
        // Classe - Professeurs
        private void class_assoc_prof_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var classeSelectionnee = dgv_class.CurrentRow;

            if (classeSelectionnee != null)
            {
                int idClasse = Convert.ToInt32(classeSelectionnee.Cells["Id"].Value);
                ClasseAssocProf c = new ClasseAssocProf(idClasse);
                c.Show();
            }
        }
        // Classe - Matieres
        private void class_assoc_matiere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var classeSelectionnee = dgv_class.CurrentRow;

            if (classeSelectionnee != null)
            {
                int idClasse = Convert.ToInt32(classeSelectionnee.Cells["Id"].Value);
                ClasseAssocMatiere c = new ClasseAssocMatiere(idClasse);
                c.Show();
            }
        }
        // Classe - Cours
        private void class_assoc_cours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var classeSelectionnee = dgv_class.CurrentRow;

            if (classeSelectionnee != null)
            {
                int idClasse = Convert.ToInt32(classeSelectionnee.Cells["Id"].Value);
                ClasseAssocCours c = new ClasseAssocCours(idClasse);
                c.Show();
            }
        }

        // Professeur
        // Ajout de prof
        private void bt_add_prof_Click(object sender, EventArgs e)
        {
            using (var db = new DbScolaire())
            {
                var c = new Professeurs
                {
                    Nom = tb_nom_prof.Text,
                    Prenom = tb_prenom_prof.Text,
                    Email = tb_mail_prof.Text,
                    Telephone = tb_tel_prof.Text,
                };

                db.TProfesseurs.Add(c);
                db.SaveChanges();  // Enregistre dans la base de données
                ChargerProf();
                clearProf();
            }
        }
        private void clearProf()
        {
            tb_nom_prof?.Clear();
            tb_prenom_prof?.Clear();
            tb_mail_prof?.Clear();
            tb_tel_prof?.Clear();
        }
        private void ChargerProf()
        {
            using (var db = new DbScolaire())
            {
                var mat = db.TProfesseurs.ToList();
                dgv_prof.DataSource = mat;
            }
        }
        private void bt_update_prof_Click(object sender, EventArgs e)
        {
            if (dgv_prof.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du professeur à modifier
                int professeurId = Convert.ToInt32(dgv_prof.SelectedRows[0].Cells["Id"].Value);

                using (var db = new DbScolaire())
                {
                    // Chercher le professeur dans la base de données
                    var professeur = db.TProfesseurs.FirstOrDefault(p => p.Id == professeurId);

                    if (professeur != null)
                    {
                        // Mettre à jour les informations du professeur
                        professeur.Nom = tb_nom_prof.Text;
                        professeur.Prenom = tb_prenom_prof.Text;
                        professeur.Email = tb_mail_prof.Text;
                        professeur.Telephone = tb_tel_prof.Text;

                        db.SaveChanges();  // Enregistre les modifications dans la base de données

                        ChargerProf();  // Rafraîchit le DataGridView
                        clearProf();  // Efface les champs de saisie
                    }
                    else
                    {
                        MessageBox.Show("Professeur non trouvé.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur à modifier.");
            }
        }

        private void dgv_profs(object sender, EventArgs e)
        {
            if (dgv_prof.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du professeur sélectionné
                int professeurId = Convert.ToInt32(dgv_prof.SelectedRows[0].Cells["Id"].Value);  // Assure-toi que la colonne "Id" est bien présente

                using (var db = new DbScolaire())
                {
                    // Chercher le professeur dans la base de données
                    var professeur = db.TProfesseurs.FirstOrDefault(p => p.Id == professeurId);

                    if (professeur != null)
                    {
                        // Remplir les champs avec les données du professeur sélectionné
                        tb_nom_prof.Text = professeur.Nom;
                        tb_prenom_prof.Text = professeur.Prenom;
                        tb_mail_prof.Text = professeur.Email;
                        tb_tel_prof.Text = professeur.Telephone;
                    }
                }
            }
        }
        //Supprimer un prof
        private void bt_delete_prof_Click(object sender, EventArgs e)
        {
            if (dgv_prof.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du professeur à supprimer
                int professeurId = Convert.ToInt32(dgv_prof.SelectedRows[0].Cells["Id"].Value);

                // Demander une confirmation avant de supprimer
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce professeur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var db = new DbScolaire())
                    {
                        // Chercher le professeur dans la base de données
                        var professeur = db.TProfesseurs.FirstOrDefault(p => p.Id == professeurId);

                        if (professeur != null)
                        {
                            // Supprimer le professeur de la base de données
                            db.TProfesseurs.Remove(professeur);
                            db.SaveChanges();  // Enregistre la suppression dans la base de données

                            ChargerProf();  // Rafraîchit le DataGridView
                            clearProf();  // Efface les champs de saisie
                        }
                        else
                        {
                            MessageBox.Show("Professeur non trouvé.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur à supprimer.");
            }
        }

        // Matieres
        // Ajout matiere
        private void bt_add_matiere_Click(object sender, EventArgs e)
        {
            using (var db = new DbScolaire())
            {
                var c = new Matieres
                {
                    NomMatiere = tb_matiere.Text,
                };

                db.TMatieres.Add(c);
                db.SaveChanges();  // Enregistre dans la base de données
                ChargerMatiere();
                clearMatiere();
            }
        }
        private void clearMatiere()
        {
            tb_matiere?.Clear();
        }
        private void ChargerMatiere()
        {
            using (var db = new DbScolaire())
            {
                var mat = db.TMatieres
                                 .Select(c => new { c.Id, c.NomMatiere })
                                 .ToList();
                dgv_matiere.DataSource = mat;
            }
        }

        private void dvg_matiere(object sender, EventArgs e)
        {
            if (dgv_matiere.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la matière sélectionnée
                int matiereId = Convert.ToInt32(dgv_matiere.SelectedRows[0].Cells["Id"].Value);  // Assure-toi que la colonne "Id" est bien présente

                using (var db = new DbScolaire())
                {
                    // Chercher la matière dans la base de données
                    var matiere = db.TMatieres.FirstOrDefault(m => m.Id == matiereId);

                    if (matiere != null)
                    {
                        // Remplir les champs avec les données de la matière sélectionnée
                        tb_matiere.Text = matiere.NomMatiere;
                    }
                }
            }
        }

        private void bt_update_matiere_Click(object sender, EventArgs e)
        {
            if (dgv_matiere.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la matière à modifier
                int matiereId = Convert.ToInt32(dgv_matiere.SelectedRows[0].Cells["Id"].Value);

                string nomMatiere = tb_matiere.Text;

                using (var db = new DbScolaire())
                {
                    // Chercher la matière dans la base de données
                    var matiereToModify = db.TMatieres.FirstOrDefault(m => m.Id == matiereId);

                    if (matiereToModify != null)
                    {
                        // Mettre à jour les informations de la matière
                        matiereToModify.NomMatiere = nomMatiere;

                        db.SaveChanges();  // Enregistre les modifications dans la base de données

                        MessageBox.Show("Matière modifiée !");
                        ChargerMatiere();  // Rafraîchit le DataGridView
                        clearMatiere();  // Efface les champs de saisie
                    }
                    else
                    {
                        MessageBox.Show("Matière non trouvée.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une matière à modifier.");
            }
        }

        private void bt_delete_matiere_Click(object sender, EventArgs e)
        {
            if (dgv_matiere.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la matière à supprimer
                int matiereId = Convert.ToInt32(dgv_matiere.SelectedRows[0].Cells["Id"].Value);

                // Demander une confirmation avant de supprimer
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette matière ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var db = new DbScolaire())
                    {
                        // Chercher la matière dans la base de données
                        var matiereToDelete = db.TMatieres.FirstOrDefault(m => m.Id == matiereId);

                        if (matiereToDelete != null)
                        {
                            // Supprimer la matière de la base de données
                            db.TMatieres.Remove(matiereToDelete);
                            db.SaveChanges();  // Enregistre la suppression dans la base de données

                            MessageBox.Show("Matière supprimée !");
                            ChargerMatiere();  // Rafraîchit le DataGridView
                            clearMatiere();  // Efface les champs de saisie
                        }
                        else
                        {
                            MessageBox.Show("Matière non trouvée.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une matière à supprimer.");
            }
        }
    }
}
