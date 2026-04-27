using NUnit.Framework;


namespace Ucu.Poo.RolePlayGame.Tests
{
    public class ItemManagmentTests
    {
        /// <summary>
        /// Chequea que se eliminene correctamente los items, deberian ser null cuando los personajes no tienen uno de sus items
        /// </summary>
        [Test]
        public void TestRemoveItem_IteamWasOrNotNull_KeepsNull()
        {
            //Elf Items
            Elf elfo = new Elf("Elden", 100, 20, 10);
            Bow arco = new Bow(5, 0);
            elfo.Bow = arco;

            Assert.AreEqual(arco, elfo.Bow);
            elfo.RemoveBow();
            Assert.AreEqual(null, elfo.Bow);
            Assert.AreEqual(null, elfo.Sword);

            //Dwarf Items
            Dwarf enano = new Dwarf("Enano", 100, 67, 67);
            Helmet cascon = new Helmet(0, 67);
            enano.Helmet = cascon;

            Assert.That(cascon, Is.EqualTo(elfo.Bow));
            enano.RemoveHelmet();
            Assert.That(null, Is.EqualTo(enano.Helmet));
            Assert.That(null, Is.EqualTo(enano.Axe));

            //Wizard Items
            Wizard gandalf = new Wizard("Gandalf", 100, 10, 0);
            MagicStaff bastonMagico = new MagicStaff(25, 25);
            SpellBook libroDeHechizos = new SpellBook(0);
            gandalf.Staff = bastonMagico;
            gandalf.SpellBook = libroDeHechizos;

            Assert.AreEqual(bastonMagico, gandalf.Staff);
            gandalf.RemoveStaff();
            Assert.AreEqual(null, gandalf.Staff);
            Assert.AreEqual(libroDeHechizos, gandalf.SpellBook);


        }


        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestRemoveItem_IteamWasOrNotNull_KeepsNull()
        {
            
            Elf elfo = new Elf("Elden", 100, 20, 10);
            Bow arco = new Bow(5, 0);
            elfo.Bow = arco;
            Assert.AreEqual(arco, elfo.Bow);
            elfo.RemoveBow();
            Assert.AreEqual(null, elfo.Bow);
            Assert.AreEqual(elfo.Sword, null);
        }
    }
}