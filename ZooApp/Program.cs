using ZooApp;
using ZooApp.Abstracts;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Rhino and demonstrate its behaviors
            Rhino rhino = new Rhino();
            rhino.Charge();  // Rhino charges
            rhino.Walk();    // Rhino walks
            rhino.Eat();     // Rhino eats
            Console.WriteLine("=======");

            // Create an instance of Monkey and demonstrate its behaviors
            Monkey monkey = new Monkey();
            monkey.ClimbTree();  // Monkey climbs trees
            monkey.Walk();       // Monkey walks
            monkey.Breathe();    // Monkey breathes
            monkey.Sleep();      // Monkey sleeps
            monkey.Move();       // Monkey moves
            monkey.Eat();        // Monkey eats
            Console.WriteLine("=======");

            // Create an instance of Bird and demonstrate its behaviors
            Bird bird = new Bird();
            bird.Fly();   // Bird flies
            bird.Eat();   // Bird eats
            Console.WriteLine("=======");

            // Create an instance of Fish and demonstrate its behaviors
            Fish fish = new Fish();
            fish.Swim();  // Fish swims
            fish.Eat();   // Fish eats
            Console.WriteLine("=======");

            Console.ReadLine();  // Wait for user input before exiting
        }
    }
}
