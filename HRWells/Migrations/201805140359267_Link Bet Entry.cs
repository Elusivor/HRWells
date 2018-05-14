namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkBetEntry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bets", "EntryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Bets", "EntryID");
            AddForeignKey("dbo.Bets", "EntryID", "dbo.Entries", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bets", "EntryID", "dbo.Entries");
            DropIndex("dbo.Bets", new[] { "EntryID" });
            DropColumn("dbo.Bets", "EntryID");
        }
    }
}
