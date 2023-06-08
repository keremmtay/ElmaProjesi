﻿using ElmaProjesi.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.DataAccessLayer.Concrete
{
    public class ElmaContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Filter> Filters { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=203-ERGUN\\NA;Database=ElmaProject;Integrated Security=true");
        }

      
    }
}
