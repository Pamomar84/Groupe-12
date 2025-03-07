using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class CoursMatieres
    {
        public int IdMatiere {get; set; }
        public Matieres matiere { get; set; }

        public int IdCours { get; set; }
        public Cours cours { get; set; }
    }
    
}
