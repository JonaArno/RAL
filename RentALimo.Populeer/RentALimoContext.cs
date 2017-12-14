using System;
using System.Data.Entity;

namespace RentALimo.Populeer
{
    public class RentALimoContext : DbContext
    {
        public DbSet<Wagen> Wagens { get; set; }
        public DbSet<Adres> Adressen { get; set; }
        public DbSet<EventingKorting> EventingKortingen { get; set; }
        public DbSet<EventingKortingItem> EventingKortingItems { get; set; }
        public DbSet<Klant> Klanten { get; set; }

        //modelBuilder pattern wordt door velen beschouwd als een bad practice
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //dit is Google copypaste code
            modelBuilder.Properties()
                .Where(p => p.Name == "Key")
                .Configure(p => p.IsKey());
        }


    }



}
