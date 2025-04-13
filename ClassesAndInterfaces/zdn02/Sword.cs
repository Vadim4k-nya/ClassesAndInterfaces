using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn02
{
    public struct Sword : IWeapon
    {
        public static string WeaponType => "Меч";
        public int WeaponStrength { get; }
        public string SpecialAbility { get; }

        public enum QualityType { Common, Good, Unique }
        public QualityType Quality { get; }

        public Sword(int weaponStrength, string specialAbility, QualityType quality)
        {
            WeaponStrength = weaponStrength;
            SpecialAbility = specialAbility;
            Quality = quality;
        }
    }
}
