using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class Professeurs
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public ICollection<ProfesseursMatieres> ProfesseursMatieres { get; set; }
        public ICollection<ProfesseursClasses>  professeursClasses { get; set; }    
    }
}
