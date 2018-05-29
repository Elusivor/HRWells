namespace HRWells.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAllTables : DbMigration
    {
        public override void Up()
        {
            #region Populate Breeds
            Sql("INSERT INTO BREEDTYPES (Name) " +
                    "VALUES ('Belguim')" +
                    ",('StandardBred')" +
                    ",('American Paint Horse')" +
                    ",('Morgan Horse')" +
                    ",('Friesian Horse')" +
                    ",('Another One')");
            #endregion
            #region Populate Horses
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
            #endregion
            #region Populate Jockeys
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
            #endregion
            #region Populate Tracks
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
            #endregion
            #region Populate Races
            Sql("INSERT INTO RACES (TOD, TrackID)" +
                "VALUES('2017-12-3 12:00:00',1)," +
                "('2017-12-10 12:00:00',2)," +
                "('2017-12-17 12:00:00',3)," +
                "('2017-12-24 12:00:00',4)," +
                "('2017-12-31 12:00:00',5)," +
                "('2018-1-7 12:00:00',6)," +
                "('2018-1-14 12:00:00',7)," +
                "('2018-1-21 12:00:00',8)," +
                "('2018-1-28 12:00:00',9)," +
                "('2018-2-4 12:00:00',10)," +
                "('2018-2-11 12:00:00',1)," +
                "('2018-2-18 12:00:00',2)," +
                "('2018-2-25 12:00:00',3)," +
                "('2018-3-4 12:00:00',4)," +
                "('2018-3-11 12:00:00',5)," +
                "('2018-3-18 12:00:00',6)," +
                "('2018-3-25 12:00:00',7)," +
                "('2018-4-1 12:00:00',8)," +
                "('2018-4-8 12:00:00',9)," +
                "('2018-4-15 12:00:00',10)," +
                "('2018-4-22 12:00:00',1)," +
                "('2018-4-29 12:00:00',2)," +
                "('2018-5-6 12:00:00',3)," +
                "('2018-5-13 12:00:00',4)," +
                "('2018-5-20 12:00:00',5)," +
                "('2018-5-27 12:00:00',6)," +
                "('2018-6-3 12:00:00',7)," +
                "('2018-6-10 12:00:00',8)," +
                "('2018-6-17 12:00:00',9)," +
                "('2018-6-24 12:00:00',10)," +
                "('2018-7-1 12:00:00',1)");
            #endregion
            #region Populate Entries
            //Populate Entries
            Sql("  INSERT INTO Entries(RaceID, LaneNr, HorseID, JockeyID)  " +
                   "VALUES(1, 1, 1, 5), " +
                   " (6, 1, 49, 21), " +
                   " (3, 2, 21, 34), " +
                   " (5, 3, 18, 23), " +
                   " (1, 4, 27, 27), " +
                   " (6, 5, 25, 14), " +
                   " (10, 6, 29, 31), " +
                   " (10, 7, 36, 12), " +
                   " (4, 8, 34, 15), " +
                   " (6, 9, 48, 22), " +
                   " (9, 10, 42, 32), " +
                   " (6, 1, 33, 12), " +
                   " (6, 2, 1, 33), " +
                   " (9, 3, 26, 25), " +
                   " (5, 4, 23, 5), " +
                   " (5, 5, 13, 24), " +
                   " (9, 6, 7, 39), " +
                   " (2, 7, 8, 29), " +
                   " (9, 8, 31, 18), " +
                   " (2, 9, 34, 23), " +
                   " (7, 10, 47, 24), " +
                   " (3, 1, 9, 20), " +
                   " (5, 2, 25, 3), " +
                   " (6, 3, 1, 32), " +
                   " (10, 4, 35, 15), " +
                   " (1, 5, 34, 6), " +
                   " (7, 6, 34, 27), " +
                   " (8, 7, 5, 26), " +
                   " (9, 8, 39, 3), " +
                   " (9, 9, 36, 29), " +
                   " (7, 10, 5, 37), " +
                   " (9, 1, 12, 23), " +
                   " (2, 4, 12, 38), " +
                   " (2, 5, 31, 36), " +
                   " (7, 6, 34, 4), " +
                   " (10, 7, 13, 13), " +
                   " (10, 8, 14, 30), " +
                   " (9, 9, 21, 25), " +
                   " (8, 10, 20, 6), " +
                   " (2, 1, 10, 28), " +
                   " (9, 2, 31, 36), " +
                   " (1, 3, 17, 10), " +
                   " (2, 4, 33, 31), " +
                   " (9, 5, 27, 9), " +
                   " (2, 6, 30, 5), " +
                   " (7, 7, 7, 36), " +
                   " (5, 8, 32, 11), " +
                   " (6, 9, 43, 31), " +
                   " (3, 10, 34, 19), " +
                   " (4, 1, 41, 33), " +
                   " (10, 2, 16, 20), " +
                   " (1, 3, 24, 32), " +
                   " (3, 4, 17, 33), " +
                   " (5, 5, 6, 21), " +
                   " (1, 6, 3, 14), " +
                   " (1, 7, 44, 34), " +
                   " (8, 8, 32, 34), " +
                   " (5, 9, 20, 11), " +
                   " (10, 10, 28, 18), " +
                   " (3, 1, 12, 25), " +
                   " (2, 2, 34, 40), " +
                   " (2, 3, 11, 19), " +
                   " (10, 4, 48, 32), " +
                   " (8, 5, 14, 19), " +
                   " (4, 6, 21, 20), " +
                   " (1, 7, 11, 6), " +
                   " (3, 8, 33, 8), " +
                   " (1, 9, 7, 17), " +
                   " (7, 10, 34, 17), " +
                   " (4, 2, 39, 30), " +
                  " (2, 3, 15, 2), " +
                  " (10, 4, 8, 31), " +
                  " (8, 5, 16, 35), " +
                  " (10, 6, 42, 32), " +
                  " (3, 7, 24, 19), " +
                  " (8, 8, 44, 9), " +
                  " (4, 9, 50, 17), " +
                  " (5, 10, 3, 30), " +
                  " (8, 1, 21, 36), " +
                  " (10, 2, 50, 36), " +
                  " (5, 3, 34, 16), " +
                  " (6, 4, 17, 9), " +
                  " (4, 5, 33, 17), " +
                  " (7, 6, 29, 32), " +
                  " (1, 7, 28, 35), " +
                  " (10, 8, 33, 21), " +
                  " (7, 9, 20, 33), " +
                  " (7, 10, 18, 37), " +
                  " (2, 1, 46, 40), " +
                  " (2, 2, 1, 18), " +
                  " (3, 3, 25, 3), " +
                  " (9, 4, 10, 40), " +
                  " (2, 5, 27, 34), " +
                  " (1, 6, 27, 21), " +
                  " (1, 7, 17, 38), " +
                  " (7, 8, 13, 37), " +
                  " (4, 9, 48, 29), " +
                  " (1, 10, 36, 13), " +
                  " (9, 1, 15, 20), " +
                  " (4, 2, 31, 26), " +
                  " (7, 3, 49, 14) ");
            #endregion
        }
        
        public override void Down()
        {
            //Reset Breeds
            Sql("DELETE FROM BREEDTYPES");
            Sql("DBCC CHECKIDENT(BREEDTYPES, RESEED,0);");
            //Reset Horses
            Sql("Delete from Horses");
            Sql("DBCC CHECKIDENT(Horses, RESEED,0);");
            //Reset Jockeys
            Sql("Delete From Jockeys");
            Sql("DBCC CHECKIDENT(Jockeys, RESEED,0);");
            //Reset Tracks
            Sql("DELETE FROM TRACKS");
            Sql("DBCC CHECKIDENT(TRACKS, RESEED,0);");
            //Reset Races
            Sql("DELETE FROM RACES");
            Sql("DBCC CHECKIDENT(RACES , RESEED, 0);");
            //Reset Entries
            Sql("Delete from Entries");
            Sql("DBCC CHECKIDENT(Entries, RESEED,0);");
        }
    }
}
