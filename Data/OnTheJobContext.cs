using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnTheJob.Models;

namespace OnTheJob.Data
{
    public class OnTheJobContext : DbContext
    {
        public OnTheJobContext (DbContextOptions<OnTheJobContext> options)
            : base(options)
        {
        }

        public DbSet<OnTheJob.Models.Job> Job { get; set; } = default!;
    }
}
