﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAppPortefolio.Models;

namespace WebAppPortefolio.Data
{
    public class PortefolioContext : DbContext
    {

        public PortefolioContext(DbContextOptions<PortefolioContext> options)
            : base(options)
        {
        }
  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();


                var connectionString = configuration.GetConnectionString("DefaultConnection");


                optionsBuilder.UseMySql(connectionString, options => options.MaxBatchSize(500));
            }
        }

        public DbSet<Utilizador> Utilizadores { get; set; }

    }
}
