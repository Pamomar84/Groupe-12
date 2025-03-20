using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groupe12Exam
{
    public partial class Agent : Form
    {
        public Agent()
        {
            InitializeComponent();
            tabPage5.Text = "Notes";
            tabPage7.Text = "Étudiants";
            ChargerNotes();
            ChargerMatieres();
            ChargerEtudiants();
            ChargerEtudiant();
            ChargerClasseForEtudiant();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new DbScolaire())
            {
                var etudiant = new Etudiant
                {
                    Matricule = tb_mat_etud.Text,
                    Nom = tb_nom_etud.Text,
                    Prenom = tb_prenom_etud.Text,
                    DateNaissance = dtp_date_etud.Value,
                    Sexe = cb_sex_etud.SelectedItem.ToString(),
                    Telephone = tb_tel_etud.Text,
                    Email = tb_email_etud.Text,
                    Adresse = tb_adress_etud.Text,
                    IdClasse = Convert.ToInt32(cb_class_etud.SelectedValue)
                };

                db.TEtudiants.Add(etudiant);
                db.SaveChanges();  // Enregistre dans la base de données
                ChargerEtudiant();
                clearEtudiant();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_etud.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'étudiant à modifier
                int etudiantId = Convert.ToInt32(dgv_etud.SelectedRows[0].Cells["Id"].Value);

                using (var db = new DbScolaire())
                {
                    // Chercher l'étudiant dans la base de données
                    var etudiant = db.TEtudiants.FirstOrDefault(et => et.Id == etudiantId);

                    if (etudiant != null)
                    {
                        // Mettre à jour les informations de l'étudiant
                        etudiant.Matricule = tb_mat_etud.Text;
                        etudiant.Nom = tb_nom_etud.Text;
                        etudiant.Prenom = tb_prenom_etud.Text;
                        etudiant.DateNaissance = dtp_date_etud.Value;
                        etudiant.Sexe = cb_sex_etud.SelectedItem.ToString();
                        etudiant.Telephone = tb_tel_etud.Text;
                        etudiant.Email = tb_email_etud.Text;
                        etudiant.Adresse = tb_adress_etud.Text;
                        etudiant.IdClasse = Convert.ToInt32(cb_class_etud.SelectedValue);

                        db.SaveChanges();  // Enregistre les modifications dans la base de données

                        ChargerEtudiant();  // Rafraîchit le DataGridView
                        clearEtudiant();  // Efface les champs de saisie
                    }
                    else
                    {
                        MessageBox.Show("Étudiant non trouvé.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_etud.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'étudiant à supprimer
                int etudiantId = Convert.ToInt32(dgv_etud.SelectedRows[0].Cells["Id"].Value);

                // Demander une confirmation avant de supprimer
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet étudiant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var db = new DbScolaire())
                    {
                        // Chercher l'étudiant dans la base de données
                        var etudiant = db.TEtudiants.FirstOrDefault(et => et.Id == etudiantId);

                        if (etudiant != null)
                        {
                            // Supprimer l'étudiant de la base de données
                            db.TEtudiants.Remove(etudiant);
                            db.SaveChanges();  // Enregistre la suppression dans la base de données

                            ChargerEtudiant();  // Rafraîchit le DataGridView
                            clearEtudiant();  // Efface les champs de saisie
                        }
                        else
                        {
                            MessageBox.Show("Étudiant non trouvé.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.");
            }
        }

        // Etuddiants
        // Ajout Etdudiant
        private void bt_add_etud_Click(object sender, EventArgs e)
        {
           
        }
        private void genereMatricule(object sender, EventArgs e)
        {
            tb_mat_etud.Text = tb_nom_etud.Text.ToUpper() + "-2025";
        }
        private void clearEtudiant()
        {
            tb_mat_etud?.Clear();
            tb_nom_etud?.Clear();
            tb_prenom_etud?.Clear();
            cb_sex_etud.Text = "Select";
            tb_tel_etud?.Clear();
            tb_adress_etud?.Clear();
            tb_email_etud?.Clear();

        }
        private void ChargerClasseForEtudiant()
        {
            using (var db = new DbScolaire())
            {
                var classe = db.TClasses
                                 .Select(m => new { m.Id, m.NomClasse })
                                 .ToList();
                cb_class_etud.DataSource = classe;
                cb_class_etud.DisplayMember = "NomClasse";
                cb_class_etud.ValueMember = "Id";
            }
        }
        private void ChargerEtudiant()
        {
            using (var db = new DbScolaire())
            {
                var etud = db.TEtudiants
                                 .ToList();
                dgv_etud.DataSource = etud;
            }
        }

        private void dvg_etudiant(object sender, EventArgs e)
        {
            if (dgv_etud.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'étudiant sélectionné
                int etudiantId = Convert.ToInt32(dgv_etud.SelectedRows[0].Cells["Id"].Value);  // Assure-toi que la colonne "Id" est bien présente

                using (var db = new DbScolaire())
                {
                    // Chercher l'étudiant dans la base de données
                    var etudiant = db.TEtudiants.FirstOrDefault(et => et.Id == etudiantId);

                    if (etudiant != null)
                    {
                        // Remplir les champs avec les données de l'étudiant sélectionné
                        tb_mat_etud.Text = etudiant.Matricule;
                        tb_nom_etud.Text = etudiant.Nom;
                        tb_prenom_etud.Text = etudiant.Prenom;
                        dtp_date_etud.Value = etudiant.DateNaissance;
                        cb_sex_etud.SelectedItem = etudiant.Sexe;
                        tb_tel_etud.Text = etudiant.Telephone;
                        tb_email_etud.Text = etudiant.Email;
                        tb_adress_etud.Text = etudiant.Adresse;
                        cb_class_etud.SelectedValue = etudiant.IdClasse;
                    }
                }
            }
        }

        // Notes
        // Ajout de note
        private void bt_add_note_Click(object sender, EventArgs e)
        {
            int idEtudiant = Convert.ToInt32(cb_etud_note.SelectedValue);
            int idMatiere = Convert.ToInt32(cb_mat_note.SelectedValue);
            float note = float.Parse(tb_note.Text);

            using (var db = new DbScolaire())
            {
                var nouvelleNote = new Notes
                {
                    IdEtudiant = idEtudiant,
                    IdMatiere = idMatiere,
                    Note = note
                };
                db.TNotes.Add(nouvelleNote);
                db.SaveChanges();
            }

            MessageBox.Show("Note ajoutée !");
            ChargerNotes();
            clearNote();
        }
        private void showOneStudent(object sender, EventArgs e)
        {
            ChargerNotes();
        }
        private void clearNote()
        {
            cb_etud_note.Text = "Select";
            cb_mat_note.Text = "Select";
            tb_note.Text = "";
        }
        private void ChargerNotes()
        {
            if (cb_etud_note.SelectedValue == null)
            {
                //   MessageBox.Show("Veuillez sélectionner un étudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idEtudiant;
            if (!int.TryParse(cb_etud_note.SelectedValue.ToString(), out idEtudiant))
            {
                //  MessageBox.Show("Erreur lors de la récupération de l'étudiant sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cb_etud_note.SelectedValue != null)
            {
                idEtudiant = Convert.ToInt32(cb_etud_note.SelectedValue);

                using (var db = new DbScolaire())
                {
                    var notes = db.TNotes
                                  .Where(n => n.IdEtudiant == idEtudiant)
                                  .Select(n => new
                                  {
                                      n.Id,
                                      Matiere = n.noteMatiere.Nom,
                                      Note = n.Note
                                  })
                                  .ToList();
                    dgv_note.DataSource = notes;
                }
            }
        }
        private void ChargerEtudiants()
        {
            using (var db = new DbScolaire())
            {
                var etudiants = db.TEtudiants
                                  .Select(e => new { e.Id, NomComplet = e.Nom + " " + e.Prenom })
                                  .ToList();
                cb_etud_note.DataSource = etudiants;
                cb_etud_note.DisplayMember = "NomComplet";
                cb_etud_note.ValueMember = "Id";
            }
        }
        private void ChargerMatieres()
        {
            using (var db = new DbScolaire())
            {
                var matieres = db.TMatieres
                                 .Select(m => new { m.Id, m.NomMatiere })
                                 .ToList();
                cb_mat_note.DataSource = matieres;
                cb_mat_note.DisplayMember = "NomMatiere";
                cb_mat_note.ValueMember = "Id";
            }
        }
        private void bt_update_note_Click(object sender, EventArgs e)
        {
            if (dgv_note.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la note à modifier
                int noteId = Convert.ToInt32(dgv_note.SelectedRows[0].Cells["Id"].Value);

                int idEtudiant = Convert.ToInt32(cb_etud_note.SelectedValue);
                int idMatiere = Convert.ToInt32(cb_mat_note.SelectedValue);
                float note = float.Parse(tb_note.Text);

                using (var db = new DbScolaire())
                {
                    // Chercher la note dans la base de données
                    var noteToModify = db.TNotes.FirstOrDefault(n => n.Id == noteId);

                    if (noteToModify != null)
                    {
                        // Mettre à jour les informations de la note
                        noteToModify.IdEtudiant = idEtudiant;
                        noteToModify.IdMatiere = idMatiere;
                        noteToModify.Note = note;

                        db.SaveChanges();  // Enregistre les modifications dans la base de données

                        MessageBox.Show("Note modifiée !");
                        ChargerNotes();  // Rafraîchit le DataGridView
                        clearNote();  // Efface les champs de saisie
                    }
                    else
                    {
                        MessageBox.Show("Note non trouvée.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une note à modifier.");
            }
        }

        private void dvg_note(object sender, EventArgs e)
        {
            if (dgv_note.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la note sélectionnée
                int noteId = Convert.ToInt32(dgv_note.SelectedRows[0].Cells["Id"].Value);  // Assure-toi que la colonne "Id" est bien présente

                using (var db = new DbScolaire())
                {
                    // Chercher la note dans la base de données
                    var note = db.TNotes.FirstOrDefault(n => n.Id == noteId);

                    if (note != null)
                    {
                        // Remplir les champs avec les données de la note sélectionnée
                        cb_etud_note.SelectedValue = note.IdEtudiant;
                        cb_mat_note.SelectedValue = note.IdMatiere;
                        tb_note.Text = note.Note.ToString();
                    }
                }
            }
        }

        private void bt_delete_note_Click(object sender, EventArgs e)
        {
            if (dgv_note.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la note à supprimer
                int noteId = Convert.ToInt32(dgv_note.SelectedRows[0].Cells["Id"].Value);

                // Demander une confirmation avant de supprimer
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette note ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var db = new DbScolaire())
                    {
                        // Chercher la note dans la base de données
                        var noteToDelete = db.TNotes.FirstOrDefault(n => n.Id == noteId);

                        if (noteToDelete != null)
                        {
                            // Supprimer la note de la base de données
                            db.TNotes.Remove(noteToDelete);
                            db.SaveChanges();  // Enregistre la suppression dans la base de données

                            MessageBox.Show("Note supprimée !");
                            ChargerNotes();  // Rafraîchit le DataGridView
                            clearNote();  // Efface les champs de saisie
                        }
                        else
                        {
                            MessageBox.Show("Note non trouvée.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une note à supprimer.");
            }
        }


        private void bt_search_etud_Click(object sender, EventArgs e)
        {
            using (var db = new DbScolaire())
            {
                // Récupération de la valeur du champ de recherche
                string searchQuery = tb_search_etud.Text.Trim();

                // Requête pour rechercher les étudiants
                var query = db.TEtudiants.AsQueryable();

                // Recherche par nom ou matricule
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    // On tente d'interpréter la recherche
                    if (int.TryParse(searchQuery, out int matricule)) // Si la recherche est un nombre, c'est un matricule
                    {
                        query = query.Where(et => et.Matricule.Contains(matricule.ToString()));
                    }
                    else if (searchQuery.All(char.IsDigit)) // Si la recherche est composée uniquement de chiffres, on considère que c'est une classe
                    {
                        if (int.TryParse(searchQuery, out int classId))
                        {
                            query = query.Where(et => et.IdClasse == classId);
                        }
                    }
                    else // Sinon, on considère que c'est une recherche par nom
                    {
                        query = query.Where(et => et.Nom.Contains(searchQuery));
                    }
                }

                // Exécution de la requête et chargement des résultats
                var result = query.ToList();

                // Mettre à jour l'interface utilisateur avec les résultats de la recherche
                dgv_etud.DataSource = result;
            }
        }

        private void cb_sort_criteria(object sender, EventArgs e)
        {
            using (var db = new DbScolaire())
            {
                // Récupérer le critère de tri sélectionné par l'utilisateur
                string sortBy = cb_sort_criteriae.SelectedItem.ToString();  // Par exemple, "Nom", "Matricule",

                // Requête de base pour récupérer tous les étudiants
                var query = db.TEtudiants.AsQueryable();

                // Tri en fonction du critère choisi
                switch (sortBy)
                {
                    case "Nom":
                        query = query.OrderBy(et => et.Nom);  // Tri par nom
                        break;
                    case "Matricule":
                        query = query.OrderBy(et => et.Matricule);  // Tri par matricule
                        break;
                    default:
                        break;
                }

                // Exécution de la requête et chargement des résultats triés
                var result = query.ToList();

                // Mettre à jour l'interface utilisateur avec les résultats triés
                dgv_etud.DataSource = result;
            }
        }

        private void searchIn(object sender, EventArgs e)
        {
            using (var db = new DbScolaire())
            {
                // Récupération de la valeur du champ de recherche
                string searchQuery = tb_search_etud.Text.Trim();

                // Requête pour rechercher les étudiants
                var query = db.TEtudiants.AsQueryable();

                // Recherche par nom ou matricule
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    // On tente d'interpréter la recherche
                    if (int.TryParse(searchQuery, out int matricule)) // Si la recherche est un nombre, c'est un matricule
                    {
                        query = query.Where(et => et.Matricule.Contains(matricule.ToString()));
                    }
                    else if (searchQuery.All(char.IsDigit)) // Si la recherche est composée uniquement de chiffres, on considère que c'est une classe
                    {
                        if (int.TryParse(searchQuery, out int classId))
                        {
                            query = query.Where(et => et.IdClasse == classId);
                        }
                    }
                    else // Sinon, on considère que c'est une recherche par nom
                    {
                        query = query.Where(et => et.Nom.Contains(searchQuery));
                    }
                }

                // Exécution de la requête et chargement des résultats
                var result = query.ToList();

                // Mettre à jour l'interface utilisateur avec les résultats de la recherche
                dgv_etud.DataSource = result;
            }
        }

    }
}
