namespace ArabaSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KullaniciGuncelleme : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AspNetUsers", name: "PhoneNumber", newName: "Telefon");
            AddColumn("dbo.AspNetUsers", "Adi", c => c.String());
            AddColumn("dbo.AspNetUsers", "Soyadi", c => c.String());
            AddColumn("dbo.AspNetUsers", "KullaniciKayitTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Adres", c => c.String());
            DropTable("dbo.Kullanici");
        }
        
        public override void Down()
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
            
            DropColumn("dbo.AspNetUsers", "Adres");
            DropColumn("dbo.AspNetUsers", "KullaniciKayitTarihi");
            DropColumn("dbo.AspNetUsers", "Soyadi");
            DropColumn("dbo.AspNetUsers", "Adi");
            RenameColumn(table: "dbo.AspNetUsers", name: "Telefon", newName: "PhoneNumber");
        }
    }
}
