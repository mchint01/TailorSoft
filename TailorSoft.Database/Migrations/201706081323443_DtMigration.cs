namespace TailorSoft.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class DtMigration : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Bills", "IX_Bill_CreatedDt");
            DropIndex("dbo.Bills", "IX_Bill_BillDt");
            DropIndex("dbo.Bills", "IX_Bill_PreferredDeliveryDt");
            AlterColumn("dbo.Bills", "CreatedDt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Bills", "BillDt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Bills", "PreferredDeliveryDt", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Bills", "CreatedDt", name: "IX_Bill_CreatedDt");
            CreateIndex("dbo.Bills", "BillDt", name: "IX_Bill_BillDt");
            CreateIndex("dbo.Bills", "PreferredDeliveryDt", name: "IX_Bill_PreferredDeliveryDt");
        }

        public override void Down()
        {
            DropIndex("dbo.Bills", "IX_Bill_PreferredDeliveryDt");
            DropIndex("dbo.Bills", "IX_Bill_BillDt");
            DropIndex("dbo.Bills", "IX_Bill_CreatedDt");
            AlterColumn("dbo.Bills", "PreferredDeliveryDt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Bills", "BillDt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Bills", "CreatedDt", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Bills", "PreferredDeliveryDt", name: "IX_Bill_PreferredDeliveryDt");
            CreateIndex("dbo.Bills", "BillDt", name: "IX_Bill_BillDt");
            CreateIndex("dbo.Bills", "CreatedDt", name: "IX_Bill_CreatedDt");
        }
    }
}
