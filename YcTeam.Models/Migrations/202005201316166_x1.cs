namespace YcTeam.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class x1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Num = c.Int(nullable: false),
                        MaterialId = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlanDate = c.DateTime(nullable: false, precision: 0),
                        ProjectId = c.Guid(nullable: false),
                        Remarks = c.String(unicode: false),
                        UpdateTime = c.DateTime(nullable: false, precision: 0),
                        CreateTime = c.DateTime(nullable: false, precision: 0),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.MaterialId)
                .ForeignKey("dbo.Projects", t => t.ProjectId)
                .Index(t => t.MaterialId)
                .Index(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plans", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Plans", "MaterialId", "dbo.Materials");
            DropIndex("dbo.Plans", new[] { "ProjectId" });
            DropIndex("dbo.Plans", new[] { "MaterialId" });
            DropTable("dbo.Plans");
        }
    }
}
