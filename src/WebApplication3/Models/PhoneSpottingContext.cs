using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class PhoneSpottingContext : DbContext
    {
        public DbSet<PhoneSpotting> Spottings { get; set; }
        private static bool _created;

        public PhoneSpottingContext()
        {
            // Create the database and schema if it doesn't exist
            if (!_created)
            {
                Database.AsRelational().ApplyMigrations();
                _created = true;
            }
        }
    }
}
