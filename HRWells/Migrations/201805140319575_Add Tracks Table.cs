namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTracksTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tracks");
        }
    }
}
