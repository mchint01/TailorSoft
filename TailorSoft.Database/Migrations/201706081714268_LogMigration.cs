namespace TailorSoft.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class LogMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Message = c.String(nullable: false),
                        MessageExtension = c.String(),
                        CreatedDt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Logs");
        }
    }
}
