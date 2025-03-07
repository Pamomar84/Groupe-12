using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class Notes
    {
        public int Id { get; set; }
        public int IdEtudiant { get; set; }
        public Etudiant notesEtudiant { get; set; }
        public int IdMatiere { get; set; }
        public Etudiant noteMatiere { get; set; }
        public float Note { get; set; }

    }
}
