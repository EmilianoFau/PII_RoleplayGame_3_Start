using System;
namespace RoleplayGame;

public class Enemies : ICharacter
{
    public string Name {get; set;}
    public int Health {get; set;}
    public int AttackValue {get; set;}
    public int DefenseValue {get; set;}
    public double VP {get; set;}
    public Enemies(string name, int health, int attackValue, int defenseValue, double vp)
    {
        this.Name = name;
        this.Health = health;
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
        this.VP = vp;
    }
    public void AddItem(IItem item)
    {
        
    }
    public void RemoveItem(IItem item)
    {

    }
    public void Cure()
    {
        this.Health = 100;
    }
    public void ReceiveAttack(int power)
    {

    }
}