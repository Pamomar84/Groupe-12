using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    public class Utilisateurs
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public enum Roles
        {   
            Administrateur,
            DE,
            Agent,
            Professeur
        }
        public string Telephone { get; set; }


    }
}
