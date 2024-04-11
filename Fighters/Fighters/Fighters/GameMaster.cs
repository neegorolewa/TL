using Fighters.Models.Fighters;
using System.ComponentModel;
using System.Diagnostics;

namespace Fighters
{
    public class GameMaster
    {
        public IFighter PlayAndGetWinner(List<IFighter> fighters)
        {
            //сортировка списка по Power боца (его мощность/выносливость)
            List<IFighter> fightersList = fighters.OrderByDescending(f => f.Power).ToList();
            int countFighter = fightersList.Count;

            int round = 0;
            while (true)
            {
                Console.WriteLine($"Раунд {round++}.");

                for (int i = 0; i < fightersList.Count; i++) 
                {
                    int attackingNumber = i;
                    int defenderNumber = (i + 1) % countFighter;

                    IFighter attacker = fightersList[attackingNumber];
                    IFighter defender = fightersList[defenderNumber];

                    Console.WriteLine($"Боец {attacker.Name} атакует бойца {defender.Name}");

                    if(FightAndCheckIfOpponentDead(attacker, defender))
                    {
                        Console.WriteLine($"Боец {defender.Name} убит!");
                        fightersList.Remove(defender);
                        countFighter -= 1;
                        if (fightersList.Count == 1 )
                        {
                            return attacker;
                        }
                    }
                }

                Console.WriteLine();
            }

            throw new UnreachableException();
        }

        private bool FightAndCheckIfOpponentDead(IFighter roundOwner, IFighter opponent)
        {
            int damage = roundOwner.CalculateDamage();
            int takenDamage = Math.Max(damage - opponent.CurrentArmor, 0);

            Console.WriteLine(
                $"Боец {opponent.Name} получает {takenDamage} урона. " +
                $"Количество жизней: {Math.Max(opponent.CurrentHealth - takenDamage, 0)}");

            opponent.TakeDamage(takenDamage);

            return opponent.CurrentHealth < 1;
        }
    }
}
