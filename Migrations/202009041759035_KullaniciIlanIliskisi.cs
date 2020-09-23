namespace ArabaSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KullaniciIlanIliskisi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ilans", "KullaniciId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Ilans", "KullaniciId");
            AddForeignKey("dbo.Ilans", "KullaniciId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ilans", "KullaniciId", "dbo.AspNetUsers");
            DropIndex("dbo.Ilans", new[] { "KullaniciId" });
            AlterColumn("dbo.Ilans", "KullaniciId", c => c.Int(nullable: false));
        }
    }
}
