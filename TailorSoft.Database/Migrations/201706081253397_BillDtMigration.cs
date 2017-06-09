namespace TailorSoft.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class BillDtMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "BillDt", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Bills", "BillDt", name: "IX_Bill_BillDt");
        }

        public override void Down()
        {
            DropIndex("dbo.Bills", "IX_Bill_BillDt");
            DropColumn("dbo.Bills", "BillDt");
        }
    }
}
