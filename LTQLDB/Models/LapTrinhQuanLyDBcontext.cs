using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LTQLDB.Models
{
    public class LapTrinhQuanLyDBcontext : DbContext
    {
            public LapTrinhQuanLyDBcontext() : base("LapTrinhQuanLyDBcontext")
        {
        }

        public DbSet<Student> Students { get; set; }
        

        
    }
}