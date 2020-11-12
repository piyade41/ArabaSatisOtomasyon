namespace ArabaSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameAraba : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Araba",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marka = c.String(),
                        Seri = c.String(),
                        Yakit = c.String(),
                        Vites = c.String(),
                        KM = c.Int(nullable: false),
                        MotorHacmi = c.Int(nullable: false),
                        HP = c.Int(nullable: false),
                        Fiyat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Araba");
        }
    }
}
