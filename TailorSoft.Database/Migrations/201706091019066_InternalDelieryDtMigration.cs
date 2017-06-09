namespace TailorSoft.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InternalDelieryDtMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "PreferredInternalDeliveryDt", c => c.DateTime());
            CreateIndex("dbo.Bills", "PreferredInternalDeliveryDt", name: "IX_Bill_PreferredInternalDeliveryDt");
        }

        public override void Down()
        {
            DropIndex("dbo.Bills", "IX_Bill_PreferredInternalDeliveryDt");
            DropColumn("dbo.Bills", "PreferredInternalDeliveryDt");
        }
    }
}
