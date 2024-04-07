using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races
{
    public class Human : IRace
    {
        public int Damage { get; } = 11;
        public int Health { get; } = 100;
        public int Armor { get; } = 10;
    }
}
