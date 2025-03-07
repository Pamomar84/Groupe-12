using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class Classes
    {
        public int Id { get; set; }
        public string NomClasse { get; set; }
        public  ICollection<ClassesCours> ClassesCours { get; set; }

        public ICollection<ProfesseursClasses> professeursClasses { get; set; }

    }
}
