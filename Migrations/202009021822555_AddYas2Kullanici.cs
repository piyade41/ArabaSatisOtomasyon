namespace ArabaSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddYas2Kullanici : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Yas", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Yas");
        }
    }
}
