namespace LocalSqlDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LocalDbCodeFirstModel : DbContext
    {
        public LocalDbCodeFirstModel()
            : base("name=localDbCodeFrstModel")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
