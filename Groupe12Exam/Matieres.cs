using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class Matieres
    {
        public int Id { get; set; }
        public string NomMatiere { get; set; }

        public ICollection<CoursMatieres> CoursMatieres { get; set; }
        public ICollection<ProfesseursMatieres> ProfesseursMatieres { get; set; }


    }
}
