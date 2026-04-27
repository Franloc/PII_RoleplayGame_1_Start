using NUnit.Framework;


namespace Ucu.Poo.RolePlayGame.Tests
{
    public class ItemManagmentTests
    {
        /// <summary>
        /// Chequea que se eliminene correctamente los items
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

            Dwarf enano = new Dwarf("Enano", 100, 20, 10);
            Bow arco = new Bow(5, 0);
            elfo.Bow = arco;
            Assert.AreEqual(arco, elfo.Bow);
            elfo.RemoveBow();
            Assert.AreEqual(null, elfo.Bow);
            Assert.AreEqual(elfo.Sword, null);

            //Wizard Items
            Wizard gandalf = new Wizard("Gandalf", 100, 10, 0);
            MagicStaff bastonMagico = new MagicStaff(25, 25);
            SpellBook libroDeHechizos = new SpellBook()
            gandalf.Staff = bastonMagico;

            Assert.AreEqual(bastonMagico, gandalf.Staff);
            gandalf.RemoveStaff();
            Assert.AreEqual(null, elfo.Bow);
            Assert.AreEqual(elfo.Sword, null);


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