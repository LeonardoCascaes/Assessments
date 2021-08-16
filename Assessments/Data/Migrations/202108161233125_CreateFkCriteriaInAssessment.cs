namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFkCriteriaInAssessment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assessments", "Criteria_Id", c => c.Int());
            CreateIndex("dbo.Assessments", "Criteria_Id");
            AddForeignKey("dbo.Assessments", "Criteria_Id", "dbo.Criteria", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assessments", "Criteria_Id", "dbo.Criteria");
            DropIndex("dbo.Assessments", new[] { "Criteria_Id" });
            DropColumn("dbo.Assessments", "Criteria_Id");
        }
    }
}
