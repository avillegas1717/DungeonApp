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
            #region Character Testing
            //object initialization syntax using the Default CTOR
            Character c1 = new()
            {
                Name = "Gandalf",
                HitChance = 75,
                Block = 15,
                MaxLife = 120,
                Life = 120 //MaxLife MUST be set before Life
            };
            //testing the ToString()
            Console.WriteLine(c1);
            //Using the FQ CTOR
            Character c2 = new("Storm Trooper", 35, 5, 130, 70);//Life(70) and MaxLife(130) are explicitly set to different values here.
            Console.WriteLine(c2);

            //Using the full health CTOR overload
            Character c3 = new("Mario Mario", 60, 20, 200);//Here, MaxLife is set to 200, and Life will default to whatever MaxLife is.
            Console.WriteLine(c3);


            #endregion

            #region Weapon Testing
            Console.Write("Equipped Weapon: ");
            //Weapon w1 = new Weapon("Wooden Stick", 1, 5, 0, false);
            //Console.WriteLine(w1);
            #endregion

        }
    }
}
