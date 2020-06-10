using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Impl
{
    public class DataBaseContext : DbContext
    {
        public DbSet<ChildEntity> Children { get; set; }
        public DbSet<ParentEntity> Parents { get; set; }
        public DbSet<ClassEntity> Classes { get; set; }
        public DbSet<TeacherEntity> Teachers { get; set; }

    }
}
