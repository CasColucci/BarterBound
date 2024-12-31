using BarterBound.Controllers;

namespace BarterBound
{
    class Program
    {
        GameController gameController = new GameController();
        public void Main()
        {
            gameController.Run();
        }
    }
}