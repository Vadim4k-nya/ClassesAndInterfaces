using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassesAndInterfaces.zdn02;

namespace ClassesAndInterfaces.Demonstrations
{
    public class GameCharacterDemo : IDemonstration
    {
        public static void Demonstration()
        {
            Sword sword1 = new Sword(15, "Критический удар", Sword.QualityType.Good);
            GameCharacter<Sword> warrior = new GameCharacter<Sword>("Артур", "Человек", sword1, 50);
            Console.WriteLine(warrior.GetCharacterInfo());
            Console.WriteLine($"Суммарная сила: {warrior.GetTotalStrength()}\n");

            Bow bow1 = new Bow(10, "Меткий выстрел", 80, 95);
            GameCharacter<Bow> archer = new GameCharacter<Bow>("Леголас", "Эльф", bow1, 40);
            Console.WriteLine(archer.GetCharacterInfo());
            Console.WriteLine($"Суммарная сила: {archer.GetTotalStrength()}\n\n\n\n");
        }
    }
}
