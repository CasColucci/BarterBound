using BarterBound.Controllers;

namespace BarterBound
{
    class Program
    {

        private static GameController gameController = new GameController();

        static void Main()
        {
            gameController.Run();

        }
    }
}
