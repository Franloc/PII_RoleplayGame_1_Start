using System;
using System.Diagnostics;

public class Elf
{
    //Atributos
    
    //Nombre del personaje
    private string name;
    public string Name
    {
        get {return this.name;} set {this.name = value;}
    }

    //Equipment
    private Bow bow;
    public Bow Bow
    {
        get {return this.bow;} set {this.bow = value;}
    }

    private Sword sword;
    public Sword Sword
    {
        get {return this.sword;} set {this.sword = value;}
    }

    private Armor armor;
    public Armor Armor
    {
        get {return this.armor;} set {this.armor = value;}
    }

    //Stats
    private int health;
    public int Health
    {
        get {return this.health;} set {this.health = value;}
    }
    private int attackValue;
    public int AttackValue
    {
        get {return this.attackValue;} set {this.attackValue = value;}
    }
    private int defenseValue;
    public int DefenseValue
    {
        get {return this.defenseValue;} set {this.defenseValue = value;}
    }
    
    //Metodos
    public void EliminarSword()
    {
        this.Sword = null;
    }
    public void EliminarBow()
    {
        this.Bow = null;
    }
    public void EliminarArmor()
    {
        this.Armor = null;
    }
    
    //Constructor
    public Elf(EName, EHealth, AV, DV)
    {
        this.name = EName;
        this.health = EHealth;
        this.attackValue = AV;
        this.defenseValue = DV;
    }
}
