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
        }

        [Test]
        public void TestGetTotalAttack_WithEquipment_ReturnsCorrectResult()
        {
            Dwarf enano = new Dwarf("Juan",100,10,10);
            Dwarf.Axe = new Axe(10,0);
            int ataque_total = enano.GetTotalAttack();
            Assert.Equals(20, ataque_total);
        }
    }
}