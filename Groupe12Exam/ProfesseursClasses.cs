using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class ProfesseursClasses
    {
        public int IdClasse { get; set; }
        public Classes classe { get; set; }

        public int IdProfesseur { get; set; }
        public Professeurs professeurs { get; set; }
    }
}
