using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Core2.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace Core2.Models
{
        public class ProductDBcontext : DbContext
        {
            public ProductDBcontext()
            {

            }
            public ProductDBcontext(DbContextOptions<ProductDBcontext> options) : base(options)
            {

            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-U3SQAU6D\\MSSQLSERVER02;Initial Catalog=Trial;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
               
            }
            public virtual DbSet<Product> Products { get; set; }
        }
    }

