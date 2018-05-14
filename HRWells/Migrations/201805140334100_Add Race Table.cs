namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRaceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TOD = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Races");
        }
    }
}
