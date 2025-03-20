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
    public partial class ClasseAssocMatiere : Form
    {
        private int idClasse;
        public ClasseAssocMatiere(int classeId)
        {
            InitializeComponent();
            idClasse = classeId;
            chargerListMatiere();
        }
        private void chargerListMatiere()
        {
            // Charger les prof qui ne sont pas encore dans la classe
            using (var context = new DbScolaire())
            {
                var matNonAssocies = context.TMatieres
                                                  .Where(e => e.Id != idClasse) // Les étudiants non associés à cette classe
                                                  .ToList();

                // Remplir la ListBox ou DataGridView avec ces étudiants
                lb_classe_assoc_matiere.DataSource = matNonAssocies;
                lb_classe_assoc_matiere.DisplayMember = "NomMatiere";  // Afficher le nom de l'étudiant
                lb_classe_assoc_matiere.ValueMember = "Id";    // Utiliser l'ID pour l'association
            }
        }
        private void bt_classe_assoc_matiere_Click(object sender, EventArgs e)
        {
            // Sélectionner les étudiants à associer
            var selectedProf = lb_classe_assoc_matiere.SelectedItems.Cast<Matieres>().ToList();

            using (var context = new DbScolaire())
            {
                foreach (var p in selectedProf)
                {
                    // Associer les prof sélectionnés à la classe
                    p.Id = idClasse;
                }
                context.SaveChanges();
            }

            MessageBox.Show("Matiere associés avec succès!");
            this.Close();
        }
    }
}
