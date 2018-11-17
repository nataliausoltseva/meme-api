using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MemeBank.Modules;

namespace MemeBank.Models
{
    public class MemeBankContext : DbContext
    {
        public MemeBankContext (DbContextOptions<MemeBankContext> options)
            : base(options)
        {
        }

        public DbSet<MemeBank.Modules.MemeItem> MemeItem { get; set; }
    }
}
