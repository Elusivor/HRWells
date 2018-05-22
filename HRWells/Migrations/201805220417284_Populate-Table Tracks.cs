namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTableTracks : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TRACKS (Name, NumberOfLanes, Distance)" +
                "VALUES ('Ascot Racecourse', 10, 2000)," +
                        "('Ballarat Turf Club', 10, 1000)," +
                        "('Belmont Park Racecourse', 10, 1699)," +
                        "('Canterbury Park Racecourse', 10, 3000)," +
                        "('Caulfield Racecourse', 10, 2000)," +
                        "('Doomben Racecourse', 10, 1000)," +
                        "('Eagle Farm Racecourse', 10, 2000)," +
                        "('Gloucester Park', 10, 3000)," +
                        "('Lismore Turf Club', 10, 2000)," +
                        "('Moonee Valley Racecourse', 10, 1500)");
        }

        public override void Down()
        {
            Sql("DELETE FROM TRACKS");
            Sql("DBCC CHECKIDENT(TRACKS, RESEED,0);");
        }
    }
}
