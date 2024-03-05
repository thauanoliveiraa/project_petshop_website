using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PegasusPetshop.Models;
using Microsoft.EntityFrameworkCore;

namespace PegasusPetshop.Database
{
    public class PetshopContext : DbContext
    {
        public PetshopContext(DbContextOptions options) : base(options){

        }

        public DbSet<PetshopModel> funcionarios {get; set;}
    
        public DbSet<ClienteModel> clientes {get; set;}

        public DbSet<PetsModel> pets {get; set;}

        public DbSet<ProdutoModel> produtos {get; set;}
    }
}