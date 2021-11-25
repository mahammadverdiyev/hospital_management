namespace HospitalManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        University = c.String(),
                        Department = c.String(),
                        StartingDate = c.DateTime(nullable: false),
                        EndingDate = c.DateTime(nullable: false),
                        Doctor_Email = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Email)
                .Index(t => t.Doctor_Email);
            
            CreateTable(
                "dbo.Employments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.String(),
                        JobDescription = c.String(),
                        WorkPlace = c.String(),
                        StartingDate = c.DateTime(nullable: false),
                        EndingDate = c.DateTime(nullable: false),
                        Doctor_Email = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Email)
                .Index(t => t.Doctor_Email);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Approved = c.Boolean(nullable: false),
                        Doctor_Email = c.String(maxLength: 128),
                        Patient_Email = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Email)
                .ForeignKey("dbo.Patients", t => t.Patient_Email)
                .Index(t => t.Doctor_Email)
                .Index(t => t.Patient_Email);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(nullable: false),
                        Sex = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Image = c.Binary(),
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(nullable: false),
                        Sex = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Image = c.Binary(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(nullable: false),
                        Sex = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Patient_Email", "dbo.Patients");
            DropForeignKey("dbo.Reservations", "Doctor_Email", "dbo.Doctors");
            DropForeignKey("dbo.Employments", "Doctor_Email", "dbo.Doctors");
            DropForeignKey("dbo.Educations", "Doctor_Email", "dbo.Doctors");
            DropIndex("dbo.Reservations", new[] { "Patient_Email" });
            DropIndex("dbo.Reservations", new[] { "Doctor_Email" });
            DropIndex("dbo.Employments", new[] { "Doctor_Email" });
            DropIndex("dbo.Educations", new[] { "Doctor_Email" });
            DropTable("dbo.Admins");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
            DropTable("dbo.Reservations");
            DropTable("dbo.Employments");
            DropTable("dbo.Educations");
        }
    }
}
