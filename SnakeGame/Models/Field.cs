using SnakeGame.Models.Enums;
using SnakeGame.Models;
using System.Numerics;

namespace SnakeGame
{
    internal class Field
    {
        public Cell[,] Cells { get; set; }
        public Snake Snake { get; set; }

        internal readonly List<Cell> TheEndLabel = new List<Cell>()
        {
        new Cell(11, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(12, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(13, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(14, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 13, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(15, 13, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 14, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(14, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(15, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 17, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(15, 17, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 18, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(15, 18, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(11, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(12, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(13, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(14, 19, CellType.Empty, ConsoleColor.Red, 2),

        new Cell(21, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(22, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(20, 13, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(23, 13, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(19, 14, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(24, 14, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(19, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(24, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(19, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(20, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(21, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(22, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(23, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(24, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(19, 17, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(24, 17, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(19, 18, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(24, 18, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(18, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(19, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(20, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(23, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(24, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(25, 19, CellType.Empty, ConsoleColor.Red, 2),

        new Cell(27, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(28, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(29, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(33, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(35, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(28, 13, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 13, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(28, 14, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 14, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(29, 14, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(33, 14, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(28, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(30, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(32, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(28, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(31, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(28, 17, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 17, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(31, 17, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(28, 18, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 18, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(27, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(28, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(29, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(33, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(35, 19, CellType.Empty, ConsoleColor.Red, 2),

        new Cell(37, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(39, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(40, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(41, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(42, 12, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 13, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(42, 13, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 14, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(39, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(40, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(41, 15, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 16, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 17, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 18, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(42, 18, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(37, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(39, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(40, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(41, 19, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(42, 19, CellType.Empty, ConsoleColor.Red, 2),

        new Cell(11, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(12, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(13, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(14, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 24, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(15, 24, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 25, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(15, 25, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(15, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 27, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(15, 27, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 28, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(15, 28, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(10, 29, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(15, 29, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(11, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(12, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(13, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(14, 30, CellType.Empty, ConsoleColor.Red, 2),

        new Cell(18, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(19, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(20, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(24, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(25, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(26, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(19, 24, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(25, 24, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(19, 25, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(25, 25, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(20, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(24, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(20, 27, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(24, 27, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(21, 28, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(23, 28, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(21, 29, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(23, 29, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(22, 30, CellType.Empty, ConsoleColor.Red, 2),

        new Cell(29, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(30, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(31, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(32, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(33, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(30, 24, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 24, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(30, 25, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(30, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(31, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(32, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(33, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(30, 27, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(30, 28, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(30, 29, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 29, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(29, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(30, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(31, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(32, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(33, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(34, 30, CellType.Empty, ConsoleColor.Red, 2),

        new Cell(37, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(39, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(40, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(41, 23, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 24, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(42, 24, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 25, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(42, 25, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(39, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(40, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(41, 26, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 27, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(40, 27, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 28, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(41, 28, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 29, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(42, 29, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(37, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(38, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(39, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(42, 30, CellType.Empty, ConsoleColor.Red, 2),
        new Cell(43, 30, CellType.Empty, ConsoleColor.Red, 2),
    };

        private static readonly Random Random = new Random();

        public Field(int height, int width)
        {
            Cells = new Cell[height / Cell.CellSize, width / Cell.CellSize];
            Snake = new Snake(7, 3);
            FillField();

            GenFood();
            DrawFood();
        }

        private void FillField()
        {
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Cells.GetLength(1); j++)
                {
                    bool isBorder = j == 0 || j == Cells.GetLength(1) - 1 || i == 0 || i == Cells.GetLength(0) - 1;
                    Cells[i, j] = new Cell(i, j, isBorder ? CellType.Border : CellType.Empty, isBorder ? ConsoleColor.White : ConsoleColor.Black);
                }
            }
        }

        internal void DrawBorders()
        {
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Cells.GetLength(1); j++)
                {
                    if (Cells[i, j].Type == CellType.Border)
                        Cells[i, j].Draw();
                }
            }
        }

        internal void DrawFood()
        {
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Cells.GetLength(1); j++)
                {
                    if (Cells[i, j].Type == CellType.Food)
                        Cells[i, j].Draw();
                }
            }
        }

        internal void ClearFood()
        {
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Cells.GetLength(1); j++)
                {
                    if (Cells[i, j].Type == CellType.Food)
                        Cells[i, j].Clear();
                }
            }

        }

        internal void GenFood()
        {
            bool isFood = false;
            int rndX = Random.Next(1, Cells.GetLength(0) - 1);
            int rndY = Random.Next(1, Cells.GetLength(1) - 1);
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Cells.GetLength(1); j++)
                {
                    if (Cells[i, j].Type == CellType.Food)
                        isFood = true;
                }
            }

            while (Cells[rndX, rndY].Type == CellType.SnakeBody || Cells[rndX, rndY].Type == CellType.SnakeHead)
            {
                rndX = Random.Next(1, Cells.GetLength(0) - 1);
                rndY = Random.Next(1, Cells.GetLength(1) - 1);
            }
            if (!isFood)
                Cells[rndX, rndY] = new Cell(rndX, rndY, CellType.Food, ConsoleColor.Green);
        }
    }
}
