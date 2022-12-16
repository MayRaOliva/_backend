using BackEnd.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BackEnd.Persitence.Context
{
    public class AplicactionDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public AplicactionDbContext(DbContextOptions<AplicactionDbContext> options); base()



    }
    