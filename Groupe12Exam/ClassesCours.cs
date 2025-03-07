using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class ClassesCours
    {
        public int IdClasse {  get; set; }
        public Classes classe { get; set; }

        public int IdCours { get; set; }
        public Cours cours { get; set; }
    }
}
