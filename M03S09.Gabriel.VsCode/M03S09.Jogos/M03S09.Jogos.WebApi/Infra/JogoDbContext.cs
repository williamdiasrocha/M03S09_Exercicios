using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M03S09.Jogos.WebApi.Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace M03S09.Jogos.WebApi.Infra
{
    public class JogoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D0KS0IT\\SQLEXPRESS;Database=M03S09.Jogos.Servidor;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EstudioConfiguration());
            modelBuilder.ApplyConfiguration(new JogoConfiguration());
        }
    }
}