using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rest_Sample.Model;

namespace Rest_Sample.Data
{
    public class Rest_SampleContext : DbContext
    {
        public Rest_SampleContext (DbContextOptions<Rest_SampleContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Rest_Sample.Model.People> People { get; set; } = default!;
    }
}
