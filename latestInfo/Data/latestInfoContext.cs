using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using latestInfo.Models;

namespace latestInfo.Data
{
    public class latestInfoContext : DbContext
    {
        public latestInfoContext (DbContextOptions<latestInfoContext> options)
            : base(options)
        {
        }

        public DbSet<latestInfo.Models.Announcements> Announcements { get; set; } = default!;
    }
}
