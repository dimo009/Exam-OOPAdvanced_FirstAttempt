﻿using Last_Army.Entities.Ammunitions;

namespace Last_Army
{
    public class MachineGun:Ammunition
    {
        // public const double Weight = 10.6;

        public MachineGun(string name)
            : base(name, weight:10.6)
        {
        }
    }
}