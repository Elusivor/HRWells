namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditTableHorseswithfieldBreed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Horses", "BreedTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Horses", "BreedTypeID");
            AddForeignKey("dbo.Horses", "BreedTypeID", "dbo.BreedTypes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Horses", "BreedTypeID", "dbo.BreedTypes");
            DropIndex("dbo.Horses", new[] { "BreedTypeID" });
            DropColumn("dbo.Horses", "BreedTypeID");
        }
    }
}
