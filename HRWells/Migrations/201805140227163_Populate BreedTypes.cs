namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateBreedTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BREEDTYPES (Name) " +
                    "VALUES ('Belguim')" +
                    ",('StandardBred')" +
                    ",('American Paint Horse')" +
                    ",('Morgan Horse')" +
                    ",('Friesian Horse')" +
                    ",('Another One')");
        }

        public override void Down()
        {
            Sql("DELETE FRO, TABLE BREEDTYPES");
            Sql("DBCC CHECKIDENT(BREEDTYPES, RESEED,0);");
        }
    }
}

