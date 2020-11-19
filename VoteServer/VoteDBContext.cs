using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoteServer
{
    public class VoteDBContext:DbContext
    {
        public VoteDBContext(DbContextOptions<VoteDBContext> options)
              : base(options) { }
        public DbSet<VoteInfo> VoteInfos { get; set; }
    }
}
