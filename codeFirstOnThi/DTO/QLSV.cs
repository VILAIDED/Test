using System;
using System.Data.Entity;
using System.Linq;

namespace codeFirstOnThi.DTO
{
    public partial class QLSV : DbContext
    {
        public QLSV()
            : base("name=QLSV")
        {
            Database.SetInitializer<QLSV>(new CreateDB());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
        public virtual DbSet<LSH> LSHs { get; set; }
        public virtual DbSet<SV> SVs { get; set; }

    }
}
