using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentALimo.Business.Test
{
    [TestClass]
    public class EventingKortingFixture
    {
        [TestMethod]
        public void NieuweKortingIsNul()
        {
            var target = new EventingKorting("Leeg");
            //const variabelen worden op een andere geheugenlocatie opgeslaan
            const double expected = 0;
            var actual = target.KortingVoorAantal(42);
            Assert.AreEqual(expected,actual);
        }
        
        //we testen op het aantal keer dat reeds gehuurd is
        [TestMethod]
        public void KortingVoorExactAantal()
        {
            var target = new EventingKorting("Simpel");
            const int aantal = 2;
            const double korting = 7.5;
            target.Nieuw(aantal, korting);
            Assert.AreEqual(korting,target.KortingVoorAantal(aantal));
        }

        //testen op de volgorde van de lijst
        [TestMethod]
        public void UitVolgorde()
        {
            var target = new EventingKorting("UitVolgorde");
            target.Nieuw(15,10);
            target.Nieuw(2, 5);
            Assert.AreEqual(target.KortingVoorAantal(15),10.0);
            Assert.AreEqual(target.KortingVoorAantal(2),5);
            //faalt bij eerste test omdat List geen automatisch sorterend type is -> type aangepast
        }


    }
}
