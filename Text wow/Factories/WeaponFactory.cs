using System;
using System.Collections.Generic;
using System.Text;
using Text_wow.Weapons;

namespace Text_wow.Factories
{
    internal class WeaponFactory
    {
        public static IWeapon CreateDagger()
        {
            return new Dagger();
        }
        public static Smörkniv CreateSmörkniv()
        {
            return new Smörkniv();
        }
        public static Klubba CreateKlubba()
        {
            return new Klubba();
        }
    }
}
