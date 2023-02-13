// ATTEMPT #1

namespace ProgrammingPrinciples.SOLID
{
  class Weapon
  {
    public int Damage { get; set; }
    public int Range { get; set; }
    public string Name { get; set; }
  
    public Weapon(string name, int damage, int range)
    {
      this.Name = name;
      this.Damage = damage;
      this.Range = range;
    }

    public void Attack()
    {
      Console.WriteLine($"Hitting with {this.Name}, dealing {this.Damage} damage");
    }
  }
}


// New feature => BOW


// ATTEMPT #2

// namespace ProgrammingPrinciples.SOLID
// {
//   class Weapon
//   {
//     public enum WeaponType {
//       Melee,
//       Ranged,
//     }

//     public WeaponType Type { get; set; }
//     public int Damage { get; set; }
//     public int Range { get; set; }
//     public string Name { get; set; }
  
//     public Weapon(string name, int damage, int range, WeaponType type)
//     {
//       this.Type = type;
//       this.Name = name;
//       this.Damage = damage;
//       this.Range = range;
//     }

//     public void Attack()
//     {
//       if (this.Type == WeaponType.Melee) {
//         Console.WriteLine($"Hitting with {this.Name}, dealing {this.Damage} damage");
//       } else {
//         Console.WriteLine($"Firing with {this.Name}, from range {this.Range} dealing {this.Damage} damage");
//       }
//     }
//   }
// }





// Attempt #3
// namespace ProgrammingPrinciples.SOLID
// {
//     public enum WeaponType {
//       Melee,
//       Ranged,
//     }

//   class Weapon
//   {

//     public WeaponType Type { get; set; }
//     public int Damage { get; set; }
//     public int Range { get; set; }
//     public string Name { get; set; }
  
//     public Weapon(string name, int damage, int range, WeaponType type)
//     {
//       this.Type = type;
//       this.Name = name;
//       this.Damage = damage;
//       this.Range = range;
//     }

//     // simple => virtual => abstract
//     public virtual void Attack() {

//     }
//   }

//   class MeleeWeapon : Weapon
//   {
//     public MeleeWeapon(string name, int damage, int range) : base(name, damage, range, WeaponType.Melee)
//     {
//     }

//     public new void Attack()
//     {
//        Console.WriteLine($"Hitting with {this.Name}, dealing {this.Damage} damage");
//     }
//   }

//   class RangedWeapon : Weapon
//   {
//     public RangedWeapon(string name, int damage, int range) : base(name, damage, range, WeaponType.Ranged)
//     {
//     }

//     public new void Attack()
//     {
//        Console.WriteLine($"Firing with {this.Name}, from range {this.Range} dealing {this.Damage} damage");
//     }
//   }
// }
