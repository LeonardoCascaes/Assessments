namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFKSkillInCriteria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Criteria", "Skill_Id", c => c.Int());
            CreateIndex("dbo.Criteria", "Skill_Id");
            AddForeignKey("dbo.Criteria", "Skill_Id", "dbo.Skills", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Criteria", "Skill_Id", "dbo.Skills");
            DropIndex("dbo.Criteria", new[] { "Skill_Id" });
            DropColumn("dbo.Criteria", "Skill_Id");
        }
    }
}
