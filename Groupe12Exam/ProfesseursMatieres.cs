using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class ProfesseursMatieres
    {
        public int IdMatiere { get; set; }
        public Matieres matiere { get; set; }

        public int IdProfesseur { get; set; }
        public Professeurs professeurs { get; set; }

    }
}
