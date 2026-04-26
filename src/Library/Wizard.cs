using System;

class Wizard
{
    // Atributos

    //Nombre
    private string name;
    public string Name
    {
        get { return this.name; } set { this.name = value; }
    }

    //Equipment (Magic staff y spellbook)
    private MagicStaff staff;
    public MagicStaff Staff
    {
        get { return this.staff; } set { this.staff = value; }
    }

    private SpellBook spellBook;
    public SpellBook SpellBook
    {
        get { return this.spellBook; } set { this.spellBook = value; }
    }

    //Stats
    private int health;
    public int Health
    {
        get { return this.health; } set { this.health = value; }
    }

    private int attackValue;
    public int AttackValue
    {
        get { return this.attackValue; } set { this.attackValue = value; }
    }

    private int defenseValue;
    public int DefenseValue
    {
        get { return this.defenseValue; } set { this.defenseValue = value; }
    }

    // Constructor
    public Wizard(string name)
    {
        this.Name = name;
    }
}