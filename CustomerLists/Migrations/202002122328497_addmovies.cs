namespace CustomerLists.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmovies : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO MOVIES (MovieName,Synopsis,Rating,ReleaseDate,DateAdded,InStock,Genre_Id) values ('Dil Chahta Hai','Movies About Friends','4','12/12/1998','12/12/1998',5,1)");
            Sql("INSERT INTO MOVIES (MovieName,Synopsis,Rating,ReleaseDate,DateAdded,InStock,Genre_Id) values ('Dil Chahta Hai 2','Movies About Friends','4','12/12/1998','12/12/1998',5,1)");

        }

        public override void Down()
        {
        }
    }
}
