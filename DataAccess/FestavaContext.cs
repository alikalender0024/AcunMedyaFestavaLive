using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.DataAccess.Context
{
    public class FestavaContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}