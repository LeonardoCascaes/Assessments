namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCriteria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Criteria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Description = c.String(),
                        Test_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id)
                .Index(t => t.Test_Id);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AmountOfQuestions = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Time = c.Single(nullable: false),
                        Result = c.Byte(nullable: false),
                        Criteria_Id = c.Int(),
                        Phase_Id = c.Int(),
                        Skill_Id = c.Int(),
                        Criteria_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criteria", t => t.Criteria_Id)
                .ForeignKey("dbo.Phases", t => t.Phase_Id)
                .ForeignKey("dbo.Skills", t => t.Skill_Id)
                .ForeignKey("dbo.Criteria", t => t.Criteria_Id1)
                .Index(t => t.Criteria_Id)
                .Index(t => t.Phase_Id)
                .Index(t => t.Skill_Id)
                .Index(t => t.Criteria_Id1);
            
            CreateTable(
                "dbo.Phases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Status = c.Boolean(nullable: false),
                        Test_Id = c.Int(),
                        Test_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id1)
                .Index(t => t.Test_Id)
                .Index(t => t.Test_Id1);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Name = c.String(),
                        Grade = c.Byte(nullable: false),
                        Test_Id = c.Int(),
                        Test_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id1)
                .Index(t => t.Test_Id)
                .Index(t => t.Test_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tests", "Criteria_Id1", "dbo.Criteria");
            DropForeignKey("dbo.Skills", "Test_Id1", "dbo.Tests");
            DropForeignKey("dbo.Skills", "Test_Id", "dbo.Tests");
            DropForeignKey("dbo.Tests", "Skill_Id", "dbo.Skills");
            DropForeignKey("dbo.Phases", "Test_Id1", "dbo.Tests");
            DropForeignKey("dbo.Phases", "Test_Id", "dbo.Tests");
            DropForeignKey("dbo.Tests", "Phase_Id", "dbo.Phases");
            DropForeignKey("dbo.Criteria", "Test_Id", "dbo.Tests");
            DropForeignKey("dbo.Tests", "Criteria_Id", "dbo.Criteria");
            DropIndex("dbo.Skills", new[] { "Test_Id1" });
            DropIndex("dbo.Skills", new[] { "Test_Id" });
            DropIndex("dbo.Phases", new[] { "Test_Id1" });
            DropIndex("dbo.Phases", new[] { "Test_Id" });
            DropIndex("dbo.Tests", new[] { "Criteria_Id1" });
            DropIndex("dbo.Tests", new[] { "Skill_Id" });
            DropIndex("dbo.Tests", new[] { "Phase_Id" });
            DropIndex("dbo.Tests", new[] { "Criteria_Id" });
            DropIndex("dbo.Criteria", new[] { "Test_Id" });
            DropTable("dbo.Skills");
            DropTable("dbo.Phases");
            DropTable("dbo.Tests");
            DropTable("dbo.Criteria");
        }
    }
}
