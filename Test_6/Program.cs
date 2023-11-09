namespace Test_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            do
            {
                game.GameStart();
            } while (game.Restart());
        }
    }
}