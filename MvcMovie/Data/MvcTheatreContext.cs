using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

    public class MvcTheatreContext : DbContext
    {
        public MvcTheatreContext (DbContextOptions<MvcTheatreContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Theatre> Theatre { get; set; }
    }
