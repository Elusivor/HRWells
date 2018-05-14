namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LaneNr = c.Int(nullable: false),
                        Horse_ID = c.Int(),
                        Jockey_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Horses", t => t.Horse_ID)
                .ForeignKey("dbo.Jockeys", t => t.Jockey_ID)
                .Index(t => t.Horse_ID)
                .Index(t => t.Jockey_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "Jockey_ID", "dbo.Jockeys");
            DropForeignKey("dbo.Entries", "Horse_ID", "dbo.Horses");
            DropIndex("dbo.Entries", new[] { "Jockey_ID" });
            DropIndex("dbo.Entries", new[] { "Horse_ID" });
            DropTable("dbo.Entries");
        }
    }
}
