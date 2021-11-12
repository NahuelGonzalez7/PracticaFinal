namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Hour = c.DateTime(nullable: false, storeType: "date"),
                        PetName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Breed = c.String(maxLength: 50, unicode: false),
                        Age = c.Int(nullable: false),
                        OwnerName = c.String(nullable: false, maxLength: 50, unicode: false),
                        CellNumber = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Turno");
        }
    }
}
