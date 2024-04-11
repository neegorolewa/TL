using Fighters.Models.Armors;
using Fighters.Models.Races;
using Fighters.Models.Weapons;
using Fighters.Models.Classes;

namespace Fighters.Models.Fighters
{
    public class Fighter : IFighter
    {
        public int MaxHealth => Race.Health + Class.Health;
        public int CurrentHealth { get; set; }

        public string Name { get; }

        public IWeapon Weapon { get; }
        public IRace Race { get; }
        public IArmor Armor { get; }
        public IClass Class { get; }

        public int Power => Race.Power;

        public int CurrentArmor => Armor.Armor + Race.Armor;

        public Fighter(string name, IRace race, IWeapon weapon, IArmor armor, IClass class_f)
        {
            Name = name;
            Race = race;
            Weapon = weapon;
            Armor = armor;
            Class = class_f;
            CurrentHealth = MaxHealth;
        }
        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;

            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }
        public int CalculateDamage()
        {
            Random random = new Random();

            double damageFactor = random.Next(80, 121) / 100;
            double currentDamage = (Race.Damage + Weapon.Damage + Class.Damage) * damageFactor;

            int criticalDamage = random.Next(0, 101);

            if (criticalDamage > 80)
            {
                return (int)currentDamage * 2;
            }

            return (int)currentDamage;
        }
    }
}
