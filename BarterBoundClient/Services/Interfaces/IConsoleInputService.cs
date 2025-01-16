namespace BarterBound.Services.Interfaces
{
    public interface IConsoleInputService
    {
        public ConsoleKeyInfo ReadKey(bool intercept);
    }
}