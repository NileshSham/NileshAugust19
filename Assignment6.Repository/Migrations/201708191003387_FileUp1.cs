namespace Assignment6.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FileUp1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.FileUploads");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FileUploads",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        length = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
