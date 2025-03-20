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
    public partial class ClasseAssocEtudiant : Form
    {
        private int idClasse;   
        public ClasseAssocEtudiant(int classeId)
        {
            InitializeComponent();
            idClasse = classeId;
            chargerListEtudiant();
        }

        private void chargerListEtudiant()
        {
            // Charger les étudiants qui ne sont pas encore dans la classe
            using (var context = new DbScolaire())
            {
                var etudiantsNonAssocies = context.TEtudiants
                                                  .Where(e => e.IdClasse != idClasse) // Les étudiants non associés à cette classe
                                                  .ToList();

                // Remplir la ListBox ou DataGridView avec ces étudiants
                lb_classe_assoc_etudiant.DataSource = etudiantsNonAssocies;
                lb_classe_assoc_etudiant.DisplayMember = "Prenom";  // Afficher le nom de l'étudiant
                lb_classe_assoc_etudiant.ValueMember = "Id";    // Utiliser l'ID pour l'association
            }
        }

        private void bt_classe_assoc_etudiant_Click(object sender, EventArgs e)
        {
            // Sélectionner les étudiants à associer
            var selectedEtudiants = lb_classe_assoc_etudiant.SelectedItems.Cast<Etudiant>().ToList();

            using (var context = new DbScolaire())
            {
                foreach (var etudiant in selectedEtudiants)
                {
                    // Associer les étudiants sélectionnés à la classe
                    etudiant.IdClasse = idClasse;
                }
                context.SaveChanges();
            }

            MessageBox.Show("Étudiants associés avec succès!");
            this.Close();
        }
    }
    
}
