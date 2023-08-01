using DungeonLibrary;

namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction
            //Intro
            Console.WriteLine("Hello Adventurer! Welcome to the whimsical world of Tiny Tails: " +
                "Adventures in Tangerine Town! Where furry fighters engage in epic battles as they clash for " +
                "dominance in an unforgettable adventure!");
                
            #endregion


            #region Player Creation
            //Player Creation, after we've learned how to create custom Datatypes.
            //Reference the notes in the TestHarness for some ideas of how to expand player creation.

            //Potential expansion - Let the user choose from a list of pre-made weapons.
            Weapon yoyo = new("YoYo", 1, 8, 10, true, WeaponType.YoYo);
            Weapon slinky = new("Slinky", 1, 8, 10, true, WeaponType.Slinky);
            Weapon guitarPickThrowingStars = new("Guitar Pick Throwing Stars", 1, 8, 10, true, WeaponType.GuitarPickThrowingStars);
            Weapon toothpicks = new("Toothpicks", 1, 8, 10, true, WeaponType.Toothpicks);

            


            //Potential expansion - Let the user choose the name and race.
            Player player = new("Child", Race.HumanChild, yoyo);

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

                            if (monster.Life <= 0) {
                                Console.WriteLine("You killed: " + monster);
                            }

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
                            Console.WriteLine("Monster defeated" + player.Score);
                            break;

                        case '4':
                            Console.WriteLine("Monster info: ");
                            //print monster details to the screen
                            Console.WriteLine(monster);
                            break;

                        case '5':
                            //quit the whole game. "reload = true;" gives us a new room and monster, "quit = true" quits the game, leaving both the inner AND outer loops.
                            Console.WriteLine("Thank you for visiting Tangerine Town!");
                            quit = true;
                            break;

                        default:
                            Console.WriteLine("Wrong Input, please try again!"); 
                            break;
                    }//end switch
                    #endregion
                    //TODO Check Player Life. If they are dead, quit the game and show them their score.

                } while (!reload && !quit); //While reload and quit are both FALSE (!true), keep looping. If either becomes true, leave the inner loop.
                #endregion


            } while (!quit);//While quit is NOT true, keep looping.

            #region Exit
            //TODO output the final score
            Console.WriteLine("Player Score: " + player.Score);
           

            #endregion

            

        }//End Main()

        private static string GetRoom()
        {
            string[] rooms =
            {
                "1", 
                "2", 
                "3", 
                "4", 
                "5"
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