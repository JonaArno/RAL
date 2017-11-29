using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RentALimo
{
    //dit is een eventkorting tabel
    //verschillende instanties van eventingkortingtabellen afhankelijk van het type klant
    public class EventingKorting
    {
        //in principe autonummeren we niet in DB's - maar "onze DBA" volhardt in de boosheid
        //readonly properties maken het moeilijk indien je XML of JSON moet gaan wegschrijven
        public int Id { get; set; }
        public string Naam { get; set; }
        //Zowel SortedSet als SortedList zijn dictionaries. Ene heeft KeyValuePairs en andere is een HashTable
        //Hash is een integer - bij int's is dit 1/1. String heeft een groter bereik. Twee waarden die aan elkaar gelijk zijn, moeten dus ook dezelfde hash hebben
        public ICollection<EventingKortingItem> Items { get; protected set; } = new SortedSet<EventingKortingItem>();
        
        //default constructor nodig voor persistentie
        protected EventingKorting() {}
        
        public EventingKorting(string naam)
        {
            Naam = naam;
        }

        public double KortingVoorAantal(int aantal)
        {
            //LastOrDefault geeft een defaultwaarde mee als Last niet gevonden wordt
            return Items.LastOrDefault(i => i.Aantal <= aantal)?.Korting??0.0;
        }
        
        //hier vul je de tabel aan
        public void Nieuw(int aantal, double korting)
        {
            Items.Add(new EventingKortingItem(aantal, korting));
        }
        
        //alt-insert met resharper
        public override string ToString()
        {
            return $"Naam eventkorting: {Naam}";
        }

    }
}