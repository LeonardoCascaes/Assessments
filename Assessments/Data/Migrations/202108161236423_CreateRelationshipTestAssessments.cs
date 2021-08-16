namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipTestAssessments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assessments", "Test_Id", c => c.Int());
            CreateIndex("dbo.Assessments", "Test_Id");
            AddForeignKey("dbo.Assessments", "Test_Id", "dbo.Tests", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assessments", "Test_Id", "dbo.Tests");
            DropIndex("dbo.Assessments", new[] { "Test_Id" });
            DropColumn("dbo.Assessments", "Test_Id");
        }
    }
}
