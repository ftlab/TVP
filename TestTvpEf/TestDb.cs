namespace TestTvpEf
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestDb : DbContext
    {
        public TestDb()
            : base("name=TestDb")
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Person)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);
        }
    }
}
