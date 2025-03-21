using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Groupe12Exam.Rapports
{
    public partial class ReleveEtudiantForm : Form
    {
        public ReleveEtudiantForm()
        {
            InitializeComponent();
            dataGridView2.CellClick += dataGridView2_CellClick;
        }
        public static int Id =-1;
        public void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow ligne = dataGridView2.Rows[e.RowIndex];
                //textLib.Text = ligne.Cells["Libelle"].Value.ToString();
                textBox1.Text = ligne.Cells["Matricule"].Value.ToString();

                Id = Convert.ToInt32(ligne.Cells["Id"].Value);




            }
        }
        private void ReleveEtudiantForm_Load(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh ()
        {
           using (var db = new DbScolaire())
            {
                dataGridView2.DataSource= db.TEtudiants.Select(p=> new  { p.Id,p.Matricule, p.Nom, p.Prenom }).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new DbScolaire())
            {
                var result = from p in db.TNotes
                            join a in db.TMatieres on p.IdMatiere equals a.Id
                            where (p.IdEtudiant == Id)
                            select new
                            {
                                a.NomMatiere,
                                p.Note
                            };
                dataGridView1.DataSource = result.ToList();
            }
        }
    }
}
