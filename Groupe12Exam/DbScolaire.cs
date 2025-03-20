using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Groupe12Exam
{
    internal class DbScolaire : DbContext
    {
        public DbScolaire() : base("connection")
        {
           
        }

        public DbSet<Classes> TClasses { get; set; }
        public DbSet<ClassesCours> TClassesCours { get; set; }
        public DbSet<Cours> TCours { get; set; }
        public DbSet<CoursMatieres> TCoursMatieres { get; set; }
        public DbSet<Etudiant> TEtudiants { get; set; }   
        public DbSet<Matieres> TMatieres { get; set; }
        public DbSet<Notes>   TNotes { get; set; }
        public DbSet<OTPCodes> TOTPCodes { get; set; }
        public DbSet<Professeurs> TProfesseurs { get; set; }
        public DbSet<ProfesseursClasses> TProfesseursClasses { get; set; }
        public DbSet<ProfesseursMatieres> TProfesseursMatieres { get; set; }
        public DbSet<Utilisateurs> TUtilisateurs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Liaison Cours et Classes 

            var CC = modelBuilder.Entity<ClassesCours>();
            CC.HasKey(cc => new { cc.IdClasse, cc.IdCours });
            CC.HasRequired(cc => cc.classe).WithMany(c=> c.ClassesCours).HasForeignKey(c => c.IdClasse);
            CC.HasRequired(cc=> cc.cours).WithMany(c=> c.ClassesCours).HasForeignKey(c => c.IdCours);

            // Liaison Cours et Matiere 
            var CM = modelBuilder.Entity<CoursMatieres>();
            CM.HasKey(cc => new { cc.IdCours, cc.IdMatiere });
            CM.HasRequired(cc=> cc.matiere).WithMany(c=> c.CoursMatieres).HasForeignKey(c => c.IdMatiere);
            CM.HasRequired(cc => cc.cours).WithMany(c => c.CoursMatieres).HasForeignKey(c => c.IdCours);

            // Liaison Professeurs et Matieres 
            var PM = modelBuilder.Entity<ProfesseursMatieres>();
            PM.HasKey(cc => new { cc.IdProfesseur, cc.IdMatiere });
            PM.HasRequired(cc => cc.matiere).WithMany(c => c.ProfesseursMatieres).HasForeignKey(c => c.IdMatiere);
            PM.HasRequired(cc => cc.professeurs).WithMany(c => c.ProfesseursMatieres).HasForeignKey(c => c.IdProfesseur);

            // Liaison Professeurs et Classes 
            var PC = modelBuilder.Entity<ProfesseursClasses>();
            PC.HasKey(cc => new { cc.IdProfesseur, cc.IdClasse });
            PC.HasRequired(cc => cc.professeurs).WithMany(c => c.professeursClasses).HasForeignKey(c => c.IdProfesseur);
            PC.HasRequired(cc => cc.classe).WithMany(c => c.professeursClasses).HasForeignKey(c => c.IdClasse);



        }
    }
}
