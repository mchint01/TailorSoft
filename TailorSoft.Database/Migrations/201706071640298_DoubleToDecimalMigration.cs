namespace TailorSoft.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class DoubleToDecimalMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bills", "SuitRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Bills", "JacketRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Bills", "SafaryRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Bills", "TrouserRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Bills", "ShirtRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Bills", "OtherRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down()
        {
            AlterColumn("dbo.Bills", "OtherRate", c => c.Double(nullable: false));
            AlterColumn("dbo.Bills", "ShirtRate", c => c.Double(nullable: false));
            AlterColumn("dbo.Bills", "TrouserRate", c => c.Double(nullable: false));
            AlterColumn("dbo.Bills", "SafaryRate", c => c.Double(nullable: false));
            AlterColumn("dbo.Bills", "JacketRate", c => c.Double(nullable: false));
            AlterColumn("dbo.Bills", "SuitRate", c => c.Double(nullable: false));
        }
    }
}
