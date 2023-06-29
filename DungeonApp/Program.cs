using DungeonLibrary;

namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction
            //TODO Intro
            Console.WriteLine("Welcome to the whimsical world of \n" +
                "Tiny Tails: Adventures in Tangerine Town! ");
            #endregion

            #region  Startup Menu
            Console.WriteLine("\nPlease choose an option:\n" +
                        "1) Read Story\n" +
                        "2) Customize Character\n" +
                        "3) Choose Room\n" +
                        "4) Exit\n");

            //Console.Clear();

            #endregion

            #region Player Creation
            //Player Creation, after we've learned how to create custom Datatypes.
            //Reference the notes in the TestHarness for some ideas of how to expand player creation.

            //Potential expansion - Let the user choose from a list of pre-made weapons.
            Weapon sword = new("Lightsaber", 1, 8, 10, true, WeaponType.Sword);

            //Potential expansion - Let the user choose the name and race.
            Player player = new("Leeroy Jenkins", Race.Human, sword);

            player.Score = 0;//initialized to zero by default. This just adds readability.
            #endregion

            //Outer Loop
            bool quit = false;
            do
            {

                #region Monster and room generation
                //We need to generate a new monster and a new room for each encounter.                
                //TODONE Generate a room - random string description
                Console.WriteLine("Room: " + GetRoom());//Room # is temporary until you add room descriptions.
                //TODO Generate a Monster (custom datatype)
                Monster monster = Monster.GetMonster();

                #endregion

                #region Encounter Loop                
                //This menu repeats until either the monster dies or the player quits, dies, or runs away.
                bool reload = false;//set to true to "reload" the monster & the room
                do
                {
                    #region Menu
                    Console.WriteLine("\nPlease choose an action:\n" +
                        "1) Attack\n" +
                        "2) Run away\n" +
                        "3) Player Info\n" +
                        "4) Monster Info\n" +
                        "5) Exit\n");

                    char action = Console.ReadKey(true).KeyChar;
                    Console.Clear();
                    switch (action)
                    {
                        case '1':
                            Console.WriteLine("Attack!");
                            reload = Combat.DoBattle(player, monster);
                            break;
                        case '2':
                            Console.WriteLine("Run Away!!");
                            //Give the monster a free attack chance
                            Combat.DoAttack(monster, player);
                            //Leave the inner loop (reload the room) and get a new room & monster.
                            reload = true;
                            break;
                        case '3':
                            Console.WriteLine("Player info: ");
                            //print player details to the screen
                            Console.WriteLine(player);
                            break;

                        case '4':
                            Console.WriteLine("Monster info: ");
                            //print monster details to the screen
                            Console.WriteLine(monster);
                            break;

                        case '5':
                            //quit the whole game. "reload = true;" gives us a new room and monster, "quit = true" quits the game, leaving both the inner AND outer loops.
                            Console.WriteLine("No one likes a quitter!");
                            quit = true;
                            break;

                        default:
                            Console.WriteLine("Do you think this is a game?? Quit playing around!");
                            break;
                    }//end switch
                    #endregion
                    //TODO Check Player Life. If they are dead, quit the game and show them their score.

                } while (!reload && !quit); //While reload and quit are both FALSE (!true), keep looping. If either becomes true, leave the inner loop.
                #endregion


            } while (!quit);//While quit is NOT true, keep looping.

            #region Exit
            //TODO output the final score
            //Console.WriteLine();
            #endregion
        }//End Main()

        private static string GetRoom()
        {
            string[] rooms =
            {
                "Attic",
                "Kitchen",
                "Child's Bedroom",
                "Basement",

            };

            Random rand = new Random();
            //rooms.Length
            int index = rand.Next(rooms.Length);
            string room = rooms[index];
            return room;

            //Refactor:
            //return rooms[new Random().Next(rooms.Length)];
        }//End GetRoom()

    }//End class
}//end namespace