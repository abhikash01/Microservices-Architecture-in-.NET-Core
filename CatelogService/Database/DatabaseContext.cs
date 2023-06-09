﻿using Microsoft.EntityFrameworkCore;

namespace CatelogService.Database
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
