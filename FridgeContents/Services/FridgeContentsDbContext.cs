using FridgeContents.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FridgeContents.Services
{
    public class FridgeContentsDbContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
    }
}