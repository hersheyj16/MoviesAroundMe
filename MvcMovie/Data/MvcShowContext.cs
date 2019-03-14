using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

    public class MvcShowContext : DbContext
    {
        public MvcShowContext (DbContextOptions<MvcShowContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Show> Show { get; set; }
    }
