using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shaheen.Models;

namespace Shaheen.Models
{
    public class TradeDbContext : DbContext
    {
        public TradeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TradeDetail> TradeDetails { get; set; }

        public DbSet<Shaheen.Models.Trade> Trade { get; set; }
    }
}
