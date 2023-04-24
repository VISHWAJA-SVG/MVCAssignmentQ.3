namespace Q._3CMS.Ass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Phone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
        }
    }
}
