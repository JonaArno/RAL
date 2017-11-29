using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace RentALimo
{
    public class EventingKortingItem : IComparable<EventingKortingItem>
    {
        //op te zoeken, wat doet protected set ?
        public int Id { get; set; }
        public int Aantal { get; protected set; }
        public double Korting { get; protected set; }
        
        //'protected', want wil zeggen dat je geen EventingKortingItem kan maken als je geen ervende klasse bent
        protected EventingKortingItem(){}
        
        public EventingKortingItem(int aantal, double korting)
        {
            Aantal = aantal;
            Korting = korting;
        }

        public int CompareTo(EventingKortingItem other)
        {
            return Aantal.CompareTo(other.Aantal);

            //returneert 1 of 0 dus volgende kan ook:
            //return Aantal - other.Aantal;
        }

        public override string ToString()
        {
            //nameof neemt gewoon de naam van de property en geeft deze weer in stringvorm
            return $"{nameof(Aantal)}: {Aantal}, {nameof(Korting)}: {Korting}";
        }

        //we kunnen niet op Id kijken, want we moeten eerst in de DB persisteren
        
    }
}