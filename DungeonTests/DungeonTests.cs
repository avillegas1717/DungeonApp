namespace DungeonTests
{
    public class DungeonTests
    {
        [Fact]
        public void Test1()
        {
            Console.Write("Equipped Weapon: ");
            Weapon w1 = new Weapon("Wooden Stick", 1, 5, 5, false, WeaponType.Sword);
            Console.WriteLine(w1.ToString());
        }
    }
}