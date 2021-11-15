namespace HospitalManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.Patients", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "FullName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "FullName", c => c.String());
            AlterColumn("dbo.Patients", "FullName", c => c.String());
            AlterColumn("dbo.Doctors", "FullName", c => c.String());
        }
    }
}
