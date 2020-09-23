namespace ArabaSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EklenenIlan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        ArabaId = c.Int(nullable: false),
                        İlanAdi = c.String(),
                        IlanKategori = c.String(),
                        IlanTarihi = c.DateTime(nullable: false),
                        İlanGunSayisi = c.Int(nullable: false),
                        Fiyat = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Araba", t => t.ArabaId, cascadeDelete: true)
                .Index(t => t.ArabaId);
            
            DropColumn("dbo.Araba", "Fiyat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Araba", "Fiyat", c => c.Int(nullable: false));
            DropForeignKey("dbo.Ilans", "ArabaId", "dbo.Araba");
            DropIndex("dbo.Ilans", new[] { "ArabaId" });
            DropTable("dbo.Ilans");
        }
    }
}
