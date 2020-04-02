using Microsoft.EntityFrameworkCore;
using MvcProjectStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProjectStarter.Data
{
    public class MvcSongContext : DbContext
    {
        public MvcSongContext(DbContextOptions<MvcSongContext> options) : base(options)
        {

        }

        public DbSet<Song> Song { get; set; }
    }
}
