namespace PS_GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES('Rock')");
            Sql("INSERT INTO Genres(Name) VALUES('Samba')");
            Sql("INSERT INTO Genres(Name) VALUES('Jazz')");
            Sql("INSERT INTO Genres(Name) VALUES('Tango')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Name IN ('Rock', 'Samba', 'Jazz', 'Tango')");
        }
    }
}
