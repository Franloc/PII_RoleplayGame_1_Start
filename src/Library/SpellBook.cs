using System.Collections.Generic;

public class SpellBook
{
    // Lista de hechizos
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
                total += spell.Power;
            }
            return total;
        }
    }

    // Defensa (puede ser 0)
    public int DefenseValue
    {
        get { return 0; }
    }
}