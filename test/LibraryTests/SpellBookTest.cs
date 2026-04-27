using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.RolePlayGame;

[TestClass]
public class SpellBookTests
{
    [TestMethod]
    public void AttackValue_WithSpells_ReturnsCorrectSum()
    {
        SpellBook book = new SpellBook(0);
        book.Spells.Add(new Spell(10));
        book.Spells.Add(new Spell(20));

        int result = book.AttackValue;

        Assert.AreEqual(30, result);
    }
}