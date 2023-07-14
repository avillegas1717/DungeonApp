using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonLibrary
{
    public class Story
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the whimsical world of \"Tiny Tails: Adventures in Tangerine Town\"!" +
                " Prepare to embark on an extraordinary RPG where a band of courageous rodents embarks on daring quests within the cozy confines of human homes.\n" +
                "In this enchanting realm, you will assume the role of a resourceful raccoon, a sassy squirrel, a mad mole, or a rat duo. " +
                "Each day brings new opportunities for discovery as you explore the vast expanse of a seemingly ordinary household, where the most mundane objects become towering landscapes to conquer.\n" +
                "From the treacherous heights of bookshelves to the labyrinthine passages behind the walls, your adventure will take you on an epic journey filled with mystery, " +
                "danger, and hidden treasures. Uncover ancient artifacts tucked away in forgotten corners, navigate perilous obstacles, and solve ingenious puzzles to unlock the secrets of the human world.\n" +
                "Form a fellowship of furry friends, each with their own unique talents and abilities. Join forces with a shrewd rat who can unlock intricate mechanisms, " +
                "or a courageous guinea pig skilled in combat. Together, you'll face formidable foes such as the sneaky house cat, mischievous insects, and even the occasional human oblivious to your presence.\n" +
                "As you delve deeper into the heart of each home, you'll encounter eccentric human characters, each with their own stories to tell. " +
                "From kind-hearted children who offer assistance to grumpy elders who guard valuable treasures, your interactions with these humans will shape the course of your adventure.\n" +
                "Customize your rodent hero with a variety of adorable outfits, accessories, and unique skills to suit your playstyle. Master the art of stealth to avoid detection, " +
                "engage in epic battles against determined foes, and utilize your tiny size to access hidden areas and uncover secrets that lie just beyond human perception.\n" +
                "But remember, while the human world is filled with wonders, it also harbors unforeseen dangers. A misplaced broom, a gust of wind, or a sudden rainstorm can pose unexpected challenges. " +
                "Your quick thinking, agility, and camaraderie with your fellow rodents will be vital in overcoming these obstacles and triumphing over adversity.\n" +
                "With each successful quest, your reputation as intrepid adventurers will grow, and the rodents of the neighborhood will look up to you as heroes. " +
                "From humble beginnings in a cozy mouse hole to epic battles in grandiose dollhouses, your journey in \"Tiny Tails: Adventures in Tangerine Town\" " +
                "will leave an indelible mark on the homes you explore and the hearts of those who dwell within them.\n" +
                "So gather your courage, sharpen your tiny swords, and embark on an unforgettable adventure in the magical world that exists just beyond human eyesight. " +
                "The miniature realm awaits, and the destiny of rodentkind lies in your tiny paws!");
        }


        //TODO figure out how to impliment ascii art:
        static void Main()
        {
            Console.WriteLine("      /\\");
            Console.WriteLine("     /  \\");
            Console.WriteLine("    /    \\");
            Console.WriteLine("   /______\\");
            Console.WriteLine("   |      |");
            Console.WriteLine("   |  []  |");
            Console.WriteLine("   |______|");
        }



        


        //TODO This is the code to get text to display like a typewriter. Save for reference later: 

        //In this code, we create a string variable text with the desired text to be typed out.
        //Then, we iterate through each character of the text using a foreach loop.Inside the loop, we use Console.Write to
        //print each character without a line break. After writing each character, we introduce a delay using Thread.Sleep to
        //simulate the typing effect.You can adjust the duration of the sleep to control the speed at which the characters are displayed.
        //Once the loop finishes, we use Console.WriteLine to add a line break after the text has been fully typed out.
        //When you run this code, it will display the text "Hello, World!" one character at a time, creating the typewriter effect.



        //    string text = "Hello, World!";

        //    foreach (char c in text)
        //    {
        //        Console.Write(c);
        //        Thread.Sleep(100); // Adjust the sleep duration for desired typing speed
        //    }

        //Console.WriteLine();




    }//end class
}//end namespace
