using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Races
{
    public  class Greek : IRace
    {
        public int Damage { get; } = 35;
        public int Health { get; } = 180;
        public int Armor { get; } = 60;
    }
}
