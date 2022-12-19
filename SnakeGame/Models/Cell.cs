using SnakeGame.Models.Enums;

namespace SnakeGame
{
    internal class Cell
    {
        private const char CellSymbol = '█';

        public int X = 0;
        public int Y = 0;

        public CellType Type { get; set; }
        public ConsoleColor Color { get; }
        public static int CellSize = 5;
        public static int FontCellSize;

        public Cell(int x, int y, CellType cellType, ConsoleColor color, int cellSize = 5)
        {
            X = x;
            Y = y;
            Type = cellType;
            Color = color;
            if (cellSize == 2)
                FontCellSize = cellSize;
            else
                CellSize = cellSize;

        }

        internal void Draw()
        {
            Console.ForegroundColor = Color;
            for (int x = 0; x < CellSize; x++)
            {
                for (int y = 0; y < CellSize; y++)
                {
                    Console.SetCursorPosition(X * CellSize + x, Y * CellSize + y);
                    Console.Write(CellSymbol);
                }
            }
        }

        internal void FontCellDraw()
        {
            Console.ForegroundColor = Color;
            for (int x = 0; x < FontCellSize; x++)
            {
                for (int y = 0; y < FontCellSize; y++)
                {
                    Console.SetCursorPosition(X * FontCellSize + x, Y * FontCellSize + y);
                    Console.Write(CellSymbol);
                }
            }
        }

        internal void Clear()
        {
            for (int x = 0; x < CellSize; x++)
            {
                for (int y = 0; y < CellSize; y++)
                {
                    Console.SetCursorPosition(X * CellSize + x, Y * CellSize + y);
                    Console.Write(" ");
                }
            }
        }
    }
}
