namespace TailorSoft.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class BillIndexMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bills", "SuitMeasurements", c => c.String(maxLength: 2000));
            AlterColumn("dbo.Bills", "JacketMeasurements", c => c.String(maxLength: 2000));
            AlterColumn("dbo.Bills", "SafaryMeasurements", c => c.String(maxLength: 2000));
            AlterColumn("dbo.Bills", "TrouserMeasurements", c => c.String(maxLength: 2000));
            AlterColumn("dbo.Bills", "ShirtMeasurements", c => c.String(maxLength: 2000));
            AlterColumn("dbo.Bills", "OtherMeasurements", c => c.String(maxLength: 2000));
            CreateIndex("dbo.Bills", "SuitMeasurements", name: "IX_Bill_SuitMeasurements");
            CreateIndex("dbo.Bills", "JacketMeasurements", name: "IX_Bill_JacketMeasurements");
            CreateIndex("dbo.Bills", "SafaryMeasurements", name: "IX_Bill_SafaryMeasurements");
            CreateIndex("dbo.Bills", "TrouserMeasurements", name: "IX_Bill_TrouserMeasurements");
            CreateIndex("dbo.Bills", "ShirtMeasurements", name: "IX_Bill_ShirtMeasurements");
            CreateIndex("dbo.Bills", "OtherMeasurements", name: "IX_Bill_OtherMeasurements");
        }

        public override void Down()
        {
            DropIndex("dbo.Bills", "IX_Bill_OtherMeasurements");
            DropIndex("dbo.Bills", "IX_Bill_ShirtMeasurements");
            DropIndex("dbo.Bills", "IX_Bill_TrouserMeasurements");
            DropIndex("dbo.Bills", "IX_Bill_SafaryMeasurements");
            DropIndex("dbo.Bills", "IX_Bill_JacketMeasurements");
            DropIndex("dbo.Bills", "IX_Bill_SuitMeasurements");
            AlterColumn("dbo.Bills", "OtherMeasurements", c => c.String());
            AlterColumn("dbo.Bills", "ShirtMeasurements", c => c.String());
            AlterColumn("dbo.Bills", "TrouserMeasurements", c => c.String());
            AlterColumn("dbo.Bills", "SafaryMeasurements", c => c.String());
            AlterColumn("dbo.Bills", "JacketMeasurements", c => c.String());
            AlterColumn("dbo.Bills", "SuitMeasurements", c => c.String());
        }
    }
}
