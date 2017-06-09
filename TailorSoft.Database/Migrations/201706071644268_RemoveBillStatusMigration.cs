namespace TailorSoft.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RemoveBillStatusMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bills", "BillStatus", c => c.String());
        }

        public override void Down()
        {
            AlterColumn("dbo.Bills", "BillStatus", c => c.Int(nullable: false));
        }
    }
}
