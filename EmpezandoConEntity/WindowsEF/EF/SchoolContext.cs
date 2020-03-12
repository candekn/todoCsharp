using System;
using System.Collections.Generic;
using System.Data.Entity; //Entity Framework
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.EF
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("KeySchoolDB") { } //Constructor por defecto del padre
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


    }
}
