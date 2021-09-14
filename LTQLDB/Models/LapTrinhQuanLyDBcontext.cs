using System.Data.Entity;

namespace LTQLDB.Models
{
    public class LapTrinhQuanLyDBContext : DbContext
    {
        public LapTrinhQuanLyDBContext() : base("name=LapTrinhQuanLyDBContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Student> Students { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
//DESKTOP - RI67TA0\SQLEXPRESS