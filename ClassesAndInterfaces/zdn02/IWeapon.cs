using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn02
{
    public interface IWeapon
    {
        static string WeaponType { get; }
        int WeaponStrength { get; }
        string SpecialAbility { get; }
    }
}
