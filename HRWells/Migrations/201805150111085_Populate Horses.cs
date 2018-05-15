namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateHorses : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('All In Luck', 6, 1, 1, 'Bob Baker', 70.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Blazing Opal', 6, 2, 2, 'Kevin Myers', 70.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Bang', 8, 3, 3, 'Jack Scott', 69.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Zac Brown', 6, 4, 4, 'Stephen Nickalls', 68.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Zedac', 6, 5, 5, 'Fraser Auret', 68.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Dal Sir Tee', 6, 6, 6, 'Mark Oulaghan', 67.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Prawn Star', 4, 7, 2, 'Kevin Myers', 67.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('May We All', 6, 8, 5, 'Fraser Auret', 68.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Cuzzie Charlie', 6, 9, 1, 'Raymond Conners', 65.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Nicoshine', 6, 10, 5, 'Tony Bambry', 65.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Magic Wonder', 5, 1, 3, 'Jo Rathbone', 65.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('the Huntsman', 5, 2, 6, 'Kevin Myers', 65.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Kipkeino', 10, 3, 4, 'Lucy de Lautour', 74.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('St Ransom', 9, 4, 1, 'Gary Vile', 70.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Guy Fox', 5, 5, 5, 'Kevin Myers', 69.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Nunchucks', 4, 6, 3, 'Kevin Myers', 68.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Sea King', 11, 7, 4, 'Kevin Myers', 68.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Zedeedudadeeko', 9, 8, 4, 'James Phillip', 68.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Mesmerize', 8, 9, 1, 'Raymond Conners', 65.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Zed Leppelin', 8, 10, 5, 'thompson Brown', 65.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Gagarin', 9, 1, 5, 'Kevin Myers', 65.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Havataste', 8, 2, 2, 'Lucy de Lautour', 58.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Master Courtsman', 5, 3, 3, 'Tony Corric', 58.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Platinum Edition', 3, 4, 1, 'Lisa Latta', 58.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Our Jocko', 5, 5, 2, 'Joshua Shaw', 58.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Post Graduate', 4, 6, 4, 'Glenn Hacche', 58.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Soiree', 4, 7, 6, 'Tony Bambry', 58.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Starbro', 3, 8, 5, 'Andrew Parkes', 58.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Under the Bridge', 4, 9, 2, 'Nigel Auret', 58.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Stunning', 4, 10, 6, 'Lisa Latta', 56.50)");
            Sql("Insert into Horses(Name, Age, number, BreedTypeID, Owner, Weight) VALUES ('Red Red Robin', 4, 1, 4, 'David Hayes', 56.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Aperol', 5, 2, 2, 'Lowry Cullen', 56.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Belladita', 4, 3, 1, 'Roydon Bergerson', 56.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Winehouse', 4, 4, 3, 'Roydon Bergerson', 56.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Lost Flag', 5, 5, 1, 'Paul Moseley', 56.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Gerardasun', 6, 6, 5, 'Fraser Auret', 60.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('the Growler', 4, 7, 2, 'Allan Sharock', 59.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Cornerstone', 4, 8, 4, 'Gary Vile', 58.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Heineken Rocks', 4, 9, 5, 'Kevin Gray', 58.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Maximillien', 5, 10, 3, 'Suzy Gordon', 58.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Star Quality', 5, 1, 4, 'Sue Walsh', 58.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Lady Style', 5, 2, 6, 'Allan Sharock', 57.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Bellissimo', 5, 3, 2, 'Brian Marriot', 57.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Maestro Max', 5, 4, 3, 'Karen Fursdon', 56.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Kate the Great', 5, 5, 4, 'Lisa Latta', 55.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Myrtle', 4, 6, 6, 'David Golsbury', 55.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Sophia Magia', 4, 7, 5, 'Roydon Bergerson', 55.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Allure', 3, 8, 2, 'Tony Bambry', 54.50)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Exhibit', 4, 9, 6, 'David Goldsbury', 54.00)");
            Sql("Insert into Horses(Name, Age, Number, BreedTypeID, Owner, Weight) VALUES ('Smoken Ace', 4, 10, 4, 'Kevin Gray', 56.00)");


        }

        public override void Down()
        {
            Sql("Delete from Horses");
            Sql("DBCC CHECKIDENT(Horses, RESEED,0);");
        }
    }
}
