using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
public class SpellBook
{
    //Lista de hechizos
    private List<Spell> spells = new List<Spell>();
    public List<Spell> Spells
    {
        get { return spells; } set { this.spells = value; }
    }

    // Valor de ataque (depende de los hechizos)
    public int AttackValue
    {
        get
        {
            int total = 0;
            foreach (Spell spell in spells)
            {
                total += spell.Power;  // El ataque total del Libro es la suma del poder de sus hechizos
            }
            return total;
        }
    }

    // Defensa
    public int DefenseValue
    {
        get { return this.defenseValue; } set { this.defenseValue = value;}
    }

    //Constructor
    public SpellBook(int DV)
    {
        this.defenseValue = DV;
    }
}
}