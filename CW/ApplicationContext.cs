namespace CW
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=ApplicationContext")
        {
        }

        public static User CurrentUser { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Contract)
                .HasForeignKey(e => new { e.User_Id, e.Service_Id })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contract>()
                .HasMany(e => e.Reports)
                .WithRequired(e => e.Contract)
                .HasForeignKey(e => new { e.User_Id, e.Serivce_Id })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.Service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Contracts)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
