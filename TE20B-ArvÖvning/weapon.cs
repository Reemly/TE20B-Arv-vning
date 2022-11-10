using System;


public class weapon
{
 public string Name { get; set; }   
 public int Damage { get; set; }
 public virtual void Attack(Character target)
 {
    Console.WriteLine("attacl!");
    target.HitPoints -= Damage;
 }
}
