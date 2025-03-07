using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class Cours
    {
        public int Id { get; set; }
        public string NomCours { get; set; }
        public string Description { get; set; }
        public  ICollection<ClassesCours> ClassesCours { get; set; }
        public ICollection<CoursMatieres> CoursMatieres { get; set; }
    }
}
