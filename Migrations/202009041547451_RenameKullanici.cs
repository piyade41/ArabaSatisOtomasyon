namespace ArabaSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKullanici : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Eposta = c.String(),
                        Telefon = c.Int(nullable: false),
                        KullaniciKayitTarihi = c.DateTime(nullable: false),
                        Adres = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kullanici");
        }
    }
}
