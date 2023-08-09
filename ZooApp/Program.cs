using ZooApp;
using ZooApp.Abstracts;


namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rhino rhino = new Rhino();
            rhino.Charge();
            rhino.Walk();
            rhino.Eat();
            Console.WriteLine("=======");

            Monkey monkey = new Monkey();
            monkey.ClimbTree();
            monkey.Walk();
            monkey.Breathe();
            monkey.Sleep();
            monkey.Move();
            monkey.Eat();
            Console.WriteLine("=======");

            Bird bird = new Bird();
            bird.Fly();
            bird.Eat();
            Console.WriteLine("=======");

            Fish fish = new Fish();
            fish.Swim();
            fish.Eat();
            Console.WriteLine("=======");

            Console.ReadLine();
        }
    }
}