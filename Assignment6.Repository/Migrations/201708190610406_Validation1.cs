namespace Assignment6.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Emp1", "State", c => c.Int(nullable: false));
            AlterColumn("dbo.Emp1", "City", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Emp1", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Emp1", "State", c => c.String(nullable: false));
        }
    }
}
