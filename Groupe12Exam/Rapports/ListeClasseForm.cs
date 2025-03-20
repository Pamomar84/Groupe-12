using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groupe12Exam.Rapports
{
    public partial class ListeClasseForm : Form
    {
        public ListeClasseForm()
        {
            InitializeComponent();
        }

        private void ListeClasseForm_Load(object sender, EventArgs e)
        {
            using(var bd = new DbScolaire())
            {
                comboBox1.DataSource = bd.TClasses.Select(p=> p.NomClasse).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DbScolaire())
            {
                var classe = comboBox1.Text;
                var idclasse = db.TClasses.FirstOrDefault(p=> p.NomClasse == classe).Id;
                var result = from p in db.TEtudiants
                             where p.IdClasse == idclasse
                             select new
                             {
                                 p.Prenom,
                                 p.Nom
                             };
                dataGridView1.DataSource = result.ToList();
                     
            }
        }
    }
}
