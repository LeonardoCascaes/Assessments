namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipPhaseTests : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tests", "Phase_Id", c => c.Int());
            CreateIndex("dbo.Tests", "Phase_Id");
            AddForeignKey("dbo.Tests", "Phase_Id", "dbo.Phases", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tests", "Phase_Id", "dbo.Phases");
            DropIndex("dbo.Tests", new[] { "Phase_Id" });
            DropColumn("dbo.Tests", "Phase_Id");
        }
    }
}
