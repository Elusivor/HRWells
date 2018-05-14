namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkRaceJockeyEntry : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entries", "Horse_ID", "dbo.Horses");
            DropForeignKey("dbo.Entries", "Jockey_ID", "dbo.Jockeys");
            DropIndex("dbo.Entries", new[] { "Horse_ID" });
            DropIndex("dbo.Entries", new[] { "Jockey_ID" });
            RenameColumn(table: "dbo.Entries", name: "Horse_ID", newName: "HorseID");
            RenameColumn(table: "dbo.Entries", name: "Jockey_ID", newName: "JockeyID");
            AddColumn("dbo.Entries", "RaceID", c => c.Int(nullable: false));
            AlterColumn("dbo.Entries", "HorseID", c => c.Int(nullable: false));
            AlterColumn("dbo.Entries", "JockeyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Entries", "HorseID");
            CreateIndex("dbo.Entries", "JockeyID");
            CreateIndex("dbo.Entries", "RaceID");
            AddForeignKey("dbo.Entries", "RaceID", "dbo.Races", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Entries", "HorseID", "dbo.Horses", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Entries", "JockeyID", "dbo.Jockeys", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "JockeyID", "dbo.Jockeys");
            DropForeignKey("dbo.Entries", "HorseID", "dbo.Horses");
            DropForeignKey("dbo.Entries", "RaceID", "dbo.Races");
            DropIndex("dbo.Entries", new[] { "RaceID" });
            DropIndex("dbo.Entries", new[] { "JockeyID" });
            DropIndex("dbo.Entries", new[] { "HorseID" });
            AlterColumn("dbo.Entries", "JockeyID", c => c.Int());
            AlterColumn("dbo.Entries", "HorseID", c => c.Int());
            DropColumn("dbo.Entries", "RaceID");
            RenameColumn(table: "dbo.Entries", name: "JockeyID", newName: "Jockey_ID");
            RenameColumn(table: "dbo.Entries", name: "HorseID", newName: "Horse_ID");
            CreateIndex("dbo.Entries", "Jockey_ID");
            CreateIndex("dbo.Entries", "Horse_ID");
            AddForeignKey("dbo.Entries", "Jockey_ID", "dbo.Jockeys", "ID");
            AddForeignKey("dbo.Entries", "Horse_ID", "dbo.Horses", "ID");
        }
    }
}
