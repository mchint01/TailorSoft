namespace TailorSoft.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                        Address = c.String(maxLength: 1000),
                        PrimaryPhone = c.String(nullable: false, maxLength: 15),
                        OtherPhone = c.String(maxLength: 15),
                        CreatedDt = c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"),
                        DeletedDt = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.PrimaryPhone, unique: true, name: "UX_Customer_PrimaryPhone");

        }

        public override void Down()
        {
            DropIndex("dbo.Customers", "UX_Customer_PrimaryPhone");
            DropTable("dbo.Customers");
        }
    }
}
