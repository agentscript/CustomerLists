namespace CustomerLists.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenreSee : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres(Name) VALUES ('Horror')");
            Sql("INSERT INTO Genres(Name) VALUES ('Action')");
            Sql("INSERT INTO Genres(Name) VALUES ('Art')");
            Sql("INSERT INTO Genres(Name) VALUES ('Random')");
        }
        
        public override void Down()
        {
        }
    }
}
