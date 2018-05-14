namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableJockeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jockeys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Weight = c.Single(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jockeys");
        }
    }
}
