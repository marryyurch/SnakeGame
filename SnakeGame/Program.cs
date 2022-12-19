// See https://aka.ms/new-console-template for more information
using System.Runtime.Versioning;
using static System.Console;

namespace SnakeGame
{
    [SupportedOSPlatform("windows")]
    class Program
    {
        internal const int FieldWidth = 100;
        internal const int FieldHeight = 100;

        public static void Main()
        {
            WindowHeight = FieldHeight;
            WindowWidth = FieldWidth;
            BufferHeight = FieldHeight;
            BufferWidth = FieldWidth;
            CursorVisible = false;

            Game game = new Game();
            game.Start();

            ReadLine();
        }
    }
}
