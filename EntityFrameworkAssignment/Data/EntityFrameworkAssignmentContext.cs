using System;
using EntityFrameworkAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkAssignment.Data
{
    public class EntityFrameworkAssignmentContext : DbContext
    {

        public DbSet<SalesItem> SalesItems { get; set; }
        public DbSet<Product> Products { get; set; }


        public EntityFrameworkAssignmentContext(DbContextOptions<EntityFrameworkAssignmentContext> options)
            : base(options)
        {
        }
    }
}
