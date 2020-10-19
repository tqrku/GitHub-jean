using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace mvcLab.Data{

    public class DatabaseContext : DbContext{

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<mvcLab.Models.Covid> Covid { get; set; }
    }
}