using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Pure.Models;

namespace Pure.Data
{
    public class ThePureContext:DbContext
    {
        public ThePureContext() : base("ThePureContext")
        {

        }

        public DbSet<Ads> Ads { get; set; }

        public DbSet <Client> Clients { get; set; }

        public DbSet <CodinBit>CodinBits { get; set; }

        public DbSet<Popular> Populars { get; set; }

        public DbSet <Promoted> Promoteds { get; set; }

        public DbSet <Recent> Recents  { get; set; }

        public DbSet <Setting> Settings { get; set; }

        public DbSet <SocialLink> SocialLinks { get; set; }
    }
}