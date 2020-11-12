namespace ArabaSatisOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IlanTarihiEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Araba", "IlanTarihi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Araba", "IlanTarihi");
        }
    }
}
