namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkRaceTrack : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Races", "TrackID", c => c.Int(nullable: false));
            CreateIndex("dbo.Races", "TrackID");
            AddForeignKey("dbo.Races", "TrackID", "dbo.Tracks", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Races", "TrackID", "dbo.Tracks");
            DropIndex("dbo.Races", new[] { "TrackID" });
            DropColumn("dbo.Races", "TrackID");
        }
    }
}
