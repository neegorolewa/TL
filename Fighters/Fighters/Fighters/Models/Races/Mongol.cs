using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races
{
    public class Mongol : IRace
    {
        public int Damage { get; } = 30;
        public int Health { get; } = 150;
        public int Armor { get; } = 20;
    }
}
