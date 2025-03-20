using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Groupe12Exam;

namespace p4_gf.admin.classes
{
    public partial class ClasseAssocProf : Form
    {
        private int idClasse;
        public ClasseAssocProf(int classeId)
        {
            InitializeComponent();
            idClasse = classeId;
            chargerListProf();
        }
        private void chargerListProf()
        {
            // Charger les prof qui ne sont pas encore dans la classe
            using (var context = new DbScolaire())
            {
                var profNonAssocies = context.TProfesseurs
                                                  .Where(e => e.Id != idClasse) // Les étudiants non associés à cette classe
                                                  .ToList();

                // Remplir la ListBox ou DataGridView avec ces étudiants
                lb_classe_assoc_prof.DataSource = profNonAssocies;
                lb_classe_assoc_prof.DisplayMember = "Prenom";  // Afficher le nom de l'étudiant
                lb_classe_assoc_prof.ValueMember = "Id";    // Utiliser l'ID pour l'association
            }
        }


        private void bt_classe_assoc_prof_Click(object sender, EventArgs e)
        {
            // Sélectionner les étudiants à associer
            var selectedProf = lb_classe_assoc_prof.SelectedItems.Cast<Professeurs>().ToList();

            using (var context = new DbScolaire())
            {
                foreach (var p in selectedProf)
                {
                    // Associer les prof sélectionnés à la classe
                    p.Id = idClasse;
                }
                context.SaveChanges();
            }

            MessageBox.Show("Professeur associés avec succès!");
            this.Close();
        }
    }
}
