using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilmesCRUDRazor.Models;

    public class RazorPagesSobreContext : DbContext
    {
        public RazorPagesSobreContext (DbContextOptions<RazorPagesSobreContext> options)
            : base(options)
        {
        }

        public DbSet<FilmesCRUDRazor.Models.Sobre> Sobre { get; set; }
    }
