using System;
using System.Data.Entity;

namespace RentALimo.Populeer
{
    public class RentALimoContext:DbContext
    {
        public DbSet<Wagen> Wagens { get; set; }
        public DbSet<Adres> Adressen { get; set; }
        public DbSet<EventingKorting> EventingKortingen { get; set; }
        public DbSet<EventingKortingItem> EventingKortingItems { get; set; }
        public DbSet<Klant> Klanten { get; set; }
    }
}
