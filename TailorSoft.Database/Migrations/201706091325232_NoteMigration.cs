namespace TailorSoft.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class NoteMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "Notes", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Bills", "Notes");
        }
    }
}
