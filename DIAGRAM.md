# Diagrama de clases

Completa a continuación tu diagrama de clases usando
[Mermaid](https://mermaid.live/edit). Debes completar el diagrama agregando las
clases y sus atributos, operaciones y relaciones faltantes. La ventaja de usar
**Mermaid** es que el diagrama es simplemente texto en un archivo
[Markdown](https://www.markdownguide.org) como este, y no gráficos ni imágenes.

```mermaid
classDiagram
    %% Relaciones de Wizard
    Wizard "1" --> "1" SpellsBook : has
    Wizard "1" --> "1" Staff : has

    %% Relaciones de Dwarf
    Dwarf "1" --> "1" Axe : has
    Dwarf "1" --> "1" Shield : has
    Dwarf "1" --> "1" Helmet : has

    %% Relaciones de Elf
    Elf "1" --> "1" Bow : has
    Elf "1" --> "1" Armor : has
    Elf "1" --> "1" Sword : has

    %% RelaciÃ³n de SpellsBook con Spell
    SpellsBook "1" --> "*" Spell : contiene

    %% Clase Wizard
    class Wizard{
      +string Name
      +SpellsBook SpellsBook
      +Staff Staff
      +int AttackValue
      +int DefenseValue
      +int Health
      +Wizard(string name)
      +ReceiveAttack(int power)
      +Cure()
      +RemoveItem(string itemTypeName)
      +ChangeStaff(Staff staff)
      +ChangeSpellsBook(SpellsBook spellsBook)
    }

    %% Clase Dwarf
    class Dwarf{
      +string Name
      +Axe Axe
      +Shield Shield
      +Helmet Helmet
      +int AttackValue
      +int DefenseValue
      +int Health
      +Dwarf(string name)
      +ReceiveAttack(int power)
      +Cure()
      +RemoveItem(string itemTypeName)
      +ChangeAxe(Axe axe)
      +ChangeShield(Shield shield)
      +ChangeHelmet(Helmet helmet)
    }

    %% Clase Elf
    class Elf{
      +string Name
      +Bow Bow
      +Sword Sword
      +Armor Armor
      +int AttackValue
      +int DefenseValue
      +int Health
      +Elf(string name)
      +ReceiveAttack(int power)
      +Cure()
      +RemoveItem(string itemTypeName)
      +ChangeBow(Bow bow)
      +ChangeArmor(Armor armor)
      +ChangeSword(Sword sword)
    }

    %% Clase SpellsBook
    class SpellsBook{
      ICollection<Spell> Spells
      +int AttackValue
      +int DefenseValue
    }

    %% Clase Spell
    class Spell{
      +int AttackValue
      +int DefenseValue
    }

    %% Armas
    class Axe{
      +int AttackValue
    }

    class Sword{
      +int AttackValue
    }

    class Bow{
      +int AttackValue
    }

    class Staff{
      +int AttackValue
      +int DefenseValue
    }

    %% Defensas
    class Shield{
      +int DefenseValue
    }

    class Armor{
      +int DefenseValue
    }

    class Helmet{
      +int DefenseValue
    }
```
