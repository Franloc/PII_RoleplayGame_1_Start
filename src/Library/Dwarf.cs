using System;

class Dwarf
{
    // Atributos de Dwarf

    //Equipment
    private string name;
    public string Name
    {
        get {return this.name;} set {this.name=value;}
    }
    private Axe axe;
    public Axe Axe
    {
        get {return this.axe;} set {this.axe=value;}
    }
    private Shield shield;
    public Shield Shield
    {
        get {return this.shield;} set {this.shield=value;}
    }
    private Helmet helmet;
    public Helmet Helmet
    {
        get {return this.helmet;} set {this.helmet=value;}
    }

    //Stats
    private int health;
    public int Health
    {
        get {return this.health;} set {this.health=value;}
    }
    private int attackValue;
    public int AttackValue
    {
        get {return this.attackValue;} set {this.attackValue=value;}
    }
    private int defenseValue;
    public int DefenseValue
    {
        get {return this.defenseValue;} set {this.defenseValue=value;}
    }


    //Constructor
    public Dwarf(string name)
    {
        this.Name=name;
    }
}
