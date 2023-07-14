using DungeonLibrary;//Added a reference to DungeonLibrary and this using statement to access Character and Weapon classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApp
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            //test your Character and your Weapon creation

            #region Weapon Testing
            Console.Write("Equipped Weapon: ");
            Weapon w1 = new Weapon("Wooden Stick", 1, 5, 5, false, WeaponType.Sword);
            Console.WriteLine(w1.ToString());
            #endregion

            #region Player Testing
            Console.WriteLine("Player: ");
            Console.Write("What is your name? ");
            string name = "Inigo Montoya";

            //Block3.Enums / Block3.ClassicMonster enum for example on how to show the user a list of an enum and let them pick one.
            //Show them the list
            //Ask them what race they want
            Race race = (Race)2;//pretend like they picked the number 1

            //I recommend creating a method in your Weapon.cs class to show them a list of weapons and let them pick one. "return" that weapon to the main program and use it in the Player ctor. 
            Player p1 = new Player(name, race, w1);
            Console.WriteLine(p1);

            Console.WriteLine("Calc Damage: " + p1.CalcDamage());
            Console.WriteLine("Calc Block: " + p1.CalcBlock());
            Console.WriteLine("Calc Hit Chance: " + p1.CalcHitChance());
            #endregion

            #region Monster testing
            Monster m1 = Monster.GetMonster();
            Console.WriteLine(m1);

            m1.Life += 10;
            Console.WriteLine(m1);
            #endregion
        }
    }//end class
}//end namespce
