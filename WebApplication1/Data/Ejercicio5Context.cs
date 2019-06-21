using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ejercicio5.Models;

    public class Ejercicio5Context : DbContext
    {
        public Ejercicio5Context (DbContextOptions<Ejercicio5Context> options)
            : base(options)
        {
        }

        public DbSet<Ejercicio5.Models.Categoria> Categoria { get; set; }
    }
