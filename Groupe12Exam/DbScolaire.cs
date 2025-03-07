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
        DbSet<Classes> TClasses { get; set; }
        DbSet<ClassesCours> TClassesCours { get; set; }
        DbSet<Cours> TCours { get; set; }
        DbSet<CoursMatieres> TCoursMatieres { get; set; }
        DbSet<Etudiant> TEtudiants { get; set; }   
        DbSet<Matieres> TMatieres { get; set; }
        DbSet<Notes>   TNotes { get; set; }
        DbSet<OTPCodes> TOTPCodes { get; set; }
        DbSet<Professeurs> TProfesseurs { get; set; }
        DbSet<ProfesseursClasses> TProfesseursClasses { get; set; }
        DbSet<ProfesseursMatieres> TProfesseursMatieres { get; set; }
        DbSet<Utilisateurs> TUtilisateurs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Liaison Cours et Classes 

            var CC = modelBuilder.Entity<ClassesCours>();
            CC.HasKey(cc => new { cc.IdClasse, cc.IdCours });
            CC.HasOptional(cc => cc.classe).WithMany(c=> c.ClassesCours).HasForeignKey(c => c.IdClasse);
            CC.HasOptional(cc=> cc.cours).WithMany(c=> c.ClassesCours).HasForeignKey(c => c.IdCours);

            // Liaison Cours et Matiere 
            var CM = modelBuilder.Entity<CoursMatieres>();
            CM.HasKey(cc => new { cc.IdCours, cc.IdMatiere });
            CM.HasOptional(cc=> cc.matiere).WithMany(c=> c.CoursMatieres).HasForeignKey(c => c.IdMatiere);
            CM.HasOptional(cc => cc.cours).WithMany(c => c.CoursMatieres).HasForeignKey(c => c.IdCours);

            // Liaison Professeurs et Matieres 
            var PM = modelBuilder.Entity<ProfesseursMatieres>();
            PM.HasKey(cc => new { cc.IdProfesseur, cc.IdMatiere });
            PM.HasOptional(cc => cc.matiere).WithMany(c => c.ProfesseursMatieres).HasForeignKey(c => c.IdMatiere);
            PM.HasOptional(cc => cc.professeurs).WithMany(c => c.ProfesseursMatieres).HasForeignKey(c => c.IdProfesseur);

            // Liaison Professeurs et Classes 
            var PC = modelBuilder.Entity<ProfesseursClasses>();
            PC.HasKey(cc => new { cc.IdProfesseur, cc.IdClasse });
            PC.HasOptional(cc => cc.professeurs).WithMany(c => c.professeursClasses).HasForeignKey(c => c.IdProfesseur);
            PC.HasOptional(cc => cc.classe).WithMany(c => c.professeursClasses).HasForeignKey(c => c.IdClasse);



        }
    }
}
