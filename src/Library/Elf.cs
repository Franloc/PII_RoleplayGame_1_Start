using System;
using System.Diagnostics;

public class Elf
{
    //Atributos
    private string name;
    public string Name
    {
        get {return this.name;} set {this.name = value;}
    }

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
    private int attackValue;
    private int defenseValue;
    private int health;




    //Constructor
    public Elf()
    {
        ;
    }
}