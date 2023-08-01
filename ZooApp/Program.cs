using ZooApp;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rhino rhino = new Rhino();
            rhino.Charge();
            Monkey monkey = new Monkey();
            monkey.ClimbTree();
            monkey.Walk();
            rhino.Walk();
        }
    }
}