using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn02
{
    public struct Bow : IWeapon
    {
        public static string WeaponType => "Лук";
        public int WeaponStrength { get; }
        public string SpecialAbility { get; }

        private int _range;
        public int Range
        {
            get => _range;
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(Range), "Дальность должна быть от 1 до 100.");
                }
                _range = value;
            }
        }

        private int _accuracy;
        public int Accuracy
        {
            get => _accuracy;
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(Accuracy), "Точность должна быть от 1 до 100.");
                }
                _accuracy = value;
            }
        }

        public Bow(int weaponStrength, string specialAbility, int range, int accuracy)
        {
            WeaponStrength = weaponStrength;
            SpecialAbility = specialAbility;
            Range = range;
            Accuracy = accuracy;
        }
    }
}
