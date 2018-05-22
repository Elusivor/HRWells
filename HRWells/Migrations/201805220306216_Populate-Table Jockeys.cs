namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTableJockeys : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Levi Stewart', 21, 52.2)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Kingsley Leis', 22, 51.6)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Ramsey Dernburg', 27, 49.5)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Amerigo Sassone', 31, 51.7)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Wilbert Rickles', 28, 50.1)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Steve Benvenisty', 20, 52.0)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Whitby Russo', 27, 48.6)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Kyle Hiles', 19, 52.4)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Wilmer Cepko', 26, 54.1)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Gregorius Flowers', 22, 52.2)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Jo Still', 20, 51.0)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Haily Slosser', 42, 53.0)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Frankie Valelly', 22, 51.4)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Andrew Bertram', 23, 51.6)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Ervin Liss', 23, 52.0)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Garrott Scanlan', 25, 49.5)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Wolfgang Plummer', 25, 48.0)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Cullen Amsden', 24, 56.1)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Augustine Pesavento', 29, 48.0)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Barnaby Alldredge', 24, 53.1)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Bob Persky', 24, 51.3)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Connor Gurish', 26, 50.6)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Norry Maddox', 27, 48.5)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Clement Decierdo', 21, 51.1)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Bendicty Teutsch', 19, 50.1)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Ross Licklider', 19, 51.2)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Quincy Lord', 32, 48.8)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Thorsten Mccarty', 35, 48.1)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Francis Von mehren', 29, 47.2)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Sonny Carty', 21, 49.5)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Brucie Wehnes', 20, 48.3)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Cyrus Ron', 21, 49.7)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Harrison Ferrari', 20, 51.8)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Niki Ting', 27, 50.9)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Stu Shallow', 24, 51.2)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Samuel Ospina', 19, 51.7)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Flinn Thiemann', 26, 50.7)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Hartwell Rios', 22, 52.4)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Neal Morss', 23, 49.2)");
            Sql("Insert into Jockeys (Name, Age, Weight) Values ('Waverley Blanche', 27, 48.5)");
        }

        public override void Down()
        {
            Sql("Delete From Jockeys Table");
            Sql("DBCC CHECKIDENT(Jockeys, RESEED,0);");
        }
    }
}
