namespace Lab3EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertCity : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cities ( Name, NumberOfResidents) VALUES ('Warszawa', 1753000)");
            Sql("INSERT INTO Cities ( Name, NumberOfResidents) VALUES ('Krakow', 767348)");
            Sql("INSERT INTO Cities ( Name, NumberOfResidents) VALUES ('Wroclaw', 628589)");
        }
        
        public override void Down()
        {
        }
    }
}
