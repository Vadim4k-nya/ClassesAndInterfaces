using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn02
{
    public class GameCharacter<T> where T : struct, IWeapon
    {
        public string Name { get; }
        public string Race { get; }
        public T Weapon { get; }
        public int Strength { get; }

        public GameCharacter(string name, string race, T weapon, int strength)
        {
            Name = name;
            Race = race;
            Weapon = weapon;
            Strength = strength;
        }

        public string GetCharacterInfo()
        {
            string weaponInfo = "";
            if (Weapon is Sword sword)
            {
                weaponInfo = $"Вид оружия: {Sword.WeaponType}, Сила оружия: {sword.WeaponStrength}, Особые возможности: {sword.SpecialAbility}, Качество: {sword.Quality}";
            }
            else if (Weapon is Bow bow)
            {
                weaponInfo = $"Вид оружия: {Bow.WeaponType}, Сила оружия: {bow.WeaponStrength}, Особые возможности: {bow.SpecialAbility}, Дальность: {bow.Range}, Точность: {bow.Accuracy}";
            }

            return $"Имя персонажа: {Name}, Раса: {Race}, {weaponInfo}, Сила персонажа: {Strength}";
        }

        public int GetTotalStrength()
        {
            return Strength + Weapon.WeaponStrength;
        }
    }
}
