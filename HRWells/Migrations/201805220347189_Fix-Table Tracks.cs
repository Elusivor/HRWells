namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTableTracks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tracks", "NumberOfLanes", c => c.Int(nullable: false));
            AddColumn("dbo.Tracks", "Distance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tracks", "Distance");
            DropColumn("dbo.Tracks", "NumberOfLanes");
        }
    }
}
