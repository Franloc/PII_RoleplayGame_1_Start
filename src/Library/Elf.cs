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
    private int baseHealth; //Vida base, se usa cuando se quiere restaurar la vida del personaje
    public int BaseHealth
    {
        get {return this.baseHealth;} set {this.baseHealth = value;}
    }
    private int health; //Vida Real del personaje
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

    //Recibir attaque y calcular nuevo valor de vida
    public void ReceiveAttack(int power)
    {
        damage = power - this.DefenseValue //El daño recibido se le descuenta el valor de defensa, por lo que si la defensa es mayor no se recibe daño.
        if (damage > 0)
        {
            this.Health -= damage;
        }
    }

    //Curar al personaje
    public void Cure()
    {
        this.Health = this.BaseHealth;
    }

    //Obtener Valores totales de Ataque y Defensa
    //Suma la stat del personaje y la de los items, a su vez chequea que existan tales items para evitar errores.
    public int GetTotalAttack()
    {
        int ataqueTotal;
        ataqueTotal += this.AttackValue;
        if (this.Bow != null){ataqueTotal += this.Bow.AttackValue;}
        if (this.Sword != null){ataqueTotal += this.Sword.AttackValue;}
        if (this.Armor != null){ataqueTotal += this.Armor.AttackValue;}
        return ataqueTotal;
    }
    public int GetTotalDefense()
    {
        int defensaTotal;
        defensaTotal += this.DefenseValue;
        if (this.Bow != null){defensaTotal += this.Bow.DefenseValue;}
        if (this.Sword != null){defensaTotal += this.Sword.DefenseValue;}
        if (this.Armor != null){defensaTotal += this.Armor.DefenseValue;}
        return defensaTotal;
    }
    
    //Eliminar Items
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
    public Elf(string EName, int EHealth, int AV, int DV)
    {
        this.name = EName;
        this.health = EHealth;
        this.baseHealth = EHealth;
        this.attackValue = AV;
        this.defenseValue = DV;
    }
}
