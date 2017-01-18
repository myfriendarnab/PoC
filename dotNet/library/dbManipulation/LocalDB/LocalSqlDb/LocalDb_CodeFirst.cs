namespace LocalSqlDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LocalDb_CodeFirst : DbContext
    {
        public LocalDb_CodeFirst()
            : base("name=LocalDb_CodeFirst")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.DepartmentName)
                .IsFixedLength();

            modelBuilder.Entity<Department>()
                .Property(e => e.DepartmentMgrId)
                .IsFixedLength();

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);
        }
    }
}
