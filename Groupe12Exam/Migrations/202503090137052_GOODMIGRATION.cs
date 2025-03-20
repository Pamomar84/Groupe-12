namespace Groupe12Exam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GOODMIGRATION : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClassesCours",
                c => new
                    {
                        IdClasse = c.Int(nullable: false),
                        IdCours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdClasse, t.IdCours })
                .ForeignKey("dbo.Classes", t => t.IdClasse, cascadeDelete: true)
                .ForeignKey("dbo.Cours", t => t.IdCours, cascadeDelete: true)
                .Index(t => t.IdClasse)
                .Index(t => t.IdCours);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoursMatieres",
                c => new
                    {
                        IdCours = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdCours, t.IdMatiere })
                .ForeignKey("dbo.Cours", t => t.IdCours, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.IdMatiere, cascadeDelete: true)
                .Index(t => t.IdCours)
                .Index(t => t.IdMatiere);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatiere = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfesseursMatieres",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdProfesseur, t.IdMatiere })
                .ForeignKey("dbo.Matieres", t => t.IdMatiere, cascadeDelete: true)
                .ForeignKey("dbo.Professeurs", t => t.IdProfesseur, cascadeDelete: true)
                .Index(t => t.IdProfesseur)
                .Index(t => t.IdMatiere);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfesseursClasses",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false),
                        IdClasse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdProfesseur, t.IdClasse })
                .ForeignKey("dbo.Classes", t => t.IdClasse, cascadeDelete: true)
                .ForeignKey("dbo.Professeurs", t => t.IdProfesseur, cascadeDelete: true)
                .Index(t => t.IdProfesseur)
                .Index(t => t.IdClasse);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Prenom = c.String(),
                        Nom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Sexe = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        IdClasse = c.Int(nullable: false),
                        classeEt_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.classeEt_Id)
                .Index(t => t.classeEt_Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEtudiant = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        Note = c.Single(nullable: false),
                        noteMatiere_Id = c.Int(),
                        notesEtudiant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.noteMatiere_Id)
                .ForeignKey("dbo.Etudiants", t => t.notesEtudiant_Id)
                .Index(t => t.noteMatiere_Id)
                .Index(t => t.notesEtudiant_Id);
            
            CreateTable(
                "dbo.OTPCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUtilisateur = c.Int(nullable: false),
                        Code = c.String(),
                        DateExpiration = c.DateTime(nullable: false),
                        UtOTP_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.UtOTP_Id)
                .Index(t => t.UtOTP_Id);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                        NomUtilisateur = c.String(),
                        MotDePasse = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OTPCodes", "UtOTP_Id", "dbo.Utilisateurs");
            DropForeignKey("dbo.Notes", "notesEtudiant_Id", "dbo.Etudiants");
            DropForeignKey("dbo.Notes", "noteMatiere_Id", "dbo.Etudiants");
            DropForeignKey("dbo.Etudiants", "classeEt_Id", "dbo.Classes");
            DropForeignKey("dbo.ClassesCours", "IdCours", "dbo.Cours");
            DropForeignKey("dbo.CoursMatieres", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.ProfesseursMatieres", "IdProfesseur", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursClasses", "IdProfesseur", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursClasses", "IdClasse", "dbo.Classes");
            DropForeignKey("dbo.ProfesseursMatieres", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.CoursMatieres", "IdCours", "dbo.Cours");
            DropForeignKey("dbo.ClassesCours", "IdClasse", "dbo.Classes");
            DropIndex("dbo.OTPCodes", new[] { "UtOTP_Id" });
            DropIndex("dbo.Notes", new[] { "notesEtudiant_Id" });
            DropIndex("dbo.Notes", new[] { "noteMatiere_Id" });
            DropIndex("dbo.Etudiants", new[] { "classeEt_Id" });
            DropIndex("dbo.ProfesseursClasses", new[] { "IdClasse" });
            DropIndex("dbo.ProfesseursClasses", new[] { "IdProfesseur" });
            DropIndex("dbo.ProfesseursMatieres", new[] { "IdMatiere" });
            DropIndex("dbo.ProfesseursMatieres", new[] { "IdProfesseur" });
            DropIndex("dbo.CoursMatieres", new[] { "IdMatiere" });
            DropIndex("dbo.CoursMatieres", new[] { "IdCours" });
            DropIndex("dbo.ClassesCours", new[] { "IdCours" });
            DropIndex("dbo.ClassesCours", new[] { "IdClasse" });
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.OTPCodes");
            DropTable("dbo.Notes");
            DropTable("dbo.Etudiants");
            DropTable("dbo.ProfesseursClasses");
            DropTable("dbo.Professeurs");
            DropTable("dbo.ProfesseursMatieres");
            DropTable("dbo.Matieres");
            DropTable("dbo.CoursMatieres");
            DropTable("dbo.Cours");
            DropTable("dbo.ClassesCours");
            DropTable("dbo.Classes");
        }
    }
}
