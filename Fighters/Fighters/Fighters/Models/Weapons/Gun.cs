﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Weapons
{
    public class Gun : IWeapon
    {
        public int Damage { get; } = 150;
    }
}
