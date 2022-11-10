using System;


public class Bazooka: RangedWeapon
{
    public Bazooka(){

    Name = "Bazooka";
    RangedDamage = 300;
    Damage = 20;
    
    }

public override  void Attack(Character target)
{
    Console.WriteLine("bazooka attack");
    target.HitPoints -= Damage;
    target.HitPoints -= Damage;
}
}
