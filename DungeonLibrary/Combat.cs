using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        // Let's create a method to handle a one sided attack. 
        public static void DoAttack(Character attacker, Character defender)
        {
            //Find the chance that the attacker lamds a hit.
            int chance = attacker.CalcHitChance(); defender.CalcBlock();
            int roll = new Random().Next(1, 101);
            //if the roll is less than or equal to the adjusted hit chance, we hit.
            bool hit = roll <= chance;

            //Thread.Sleep() will temporarily suspend the program, giving the illusion that something 
            //is happening, like a dice roll for instance.
            Thread.Sleep(300);

            if (hit) //if (roll <= chance)
            { 
                //calculate the damage
                int damage = attacker.CalcDamage();

                //subtract and assign it to the defender's life
                defender.Life -= damage;

                //output the result
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damage} damage!");
                //reset color
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{attacker.Name} ");
                Console.ResetColor();
                Console.WriteLine("misssed!");
                              
            }
        }//end DoAttack

        public static bool DoBattle(Player player, Monster monster) 
        {
            //Potential expansion: Initiative
            //Consider adding an "Initiative" property to Charachter.cs
            //Then check the iitiative to determine who attacks first.
            //if player.Initiatuve > monster.Initiative then DoAttack(player, monster)
            //for this example, we will give player initiative by default

            //Potential Expansion: Give certain player races or charachters with a certain weapon
            //an extra attack or some other advantage.

            DoAttack(player, monster);
            if (monster.Life > 0) 
            {
                DoAttack(monster, player);
                return false;
            }
            else
            {
                //Possible Expansion: Combat Rewards
                //Monsters could drop loot (Item class & inventory (List<Item>))
                //Gold that could be used to heal between battles

                player.Score++;

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\nYou defeated {monster.Name}!\n");
                Console.ResetColor();
                return true;
            }
        }//end DoBattle()


    }//end class
}//end namespace
