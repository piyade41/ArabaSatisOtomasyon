namespace ArabaSatisOtomasyon.Data
{
    using ArabaSatisOtomasyon.Entities;
    using ArabaSatisOtomasyon.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // Your context has been configured to use a 'ArabaSatisOtomasyon' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ArabaSatisOtomasyon.ArabaSatisOtomasyon' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ArabaSatisOtomasyon' 
        // connection string in the application configuration file.
        public ApplicationDbContext()
            : base("name=DefaultConnection")
        {
        }
        public virtual DbSet<Araba> Araba { get; set; }
        public virtual DbSet<Ilan> Ilan { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //// configures one-to-many relationship
            //modelBuilder.Entity<Ilan>()
            //    .HasRequired<>(s => s.CurrentGrade)
            //    .WithMany(g => g.Students)
            //    .HasForeignKey<int>(s => s.CurrentGradeId);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}