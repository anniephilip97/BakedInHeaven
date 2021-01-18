using Bake.DataService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.DataService
{
    public class BakeDbContext: DbContext
    {
        public BakeDbContext (DbContextOptions<BakeDbContext> opt): base(opt)
        {

        }
        
        public DbSet<customer> customers { get; set; }
        public DbSet<item> items { get; set; }
        public DbSet<order> orders { get; set; }
    }
}
