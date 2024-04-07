using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races
{
    public class Tatar : IRace
    {
        public int Damage { get; } = 40;
        public int Health { get; } = 200;
        public int Armor { get; } = 40;
    }
}
