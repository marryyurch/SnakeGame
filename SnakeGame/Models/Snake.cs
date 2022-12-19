using SnakeGame.Models.Enums;
using System.ComponentModel;

namespace SnakeGame
{
    internal class Snake
    {
        public Direction currentDirection = Direction.Right;
        public Queue<Cell> Body = new Queue<Cell>();

        public Cell Head { get; private set; }

        public Snake(int x, int y, int bodyLength = 3)
        {
            Head = new Cell(x, y, CellType.SnakeHead, ConsoleColor.Red);
            for (int i = bodyLength - 1; i >= 0; i--)
                Body.Enqueue(new Cell(x - i - 1, y, CellType.SnakeBody, ConsoleColor.Yellow));
        }

        internal void Draw()
        {
            Head.Draw();
            foreach (var cell in Body)
                cell.Draw();
        }
        internal void Clear()
        {
            Head?.Clear();
            foreach (var cell in Body)
                cell.Clear();
        }

        internal void Move(Field field, ref bool isRunning, bool eat = false)
        {
            Direction direction = ReadMovement(currentDirection);

            Body.Enqueue(new Cell(Head.X, Head.Y, CellType.SnakeBody, ConsoleColor.Yellow));
            if (!eat)
                Body.Dequeue();

            Head = direction switch
            {
                Direction.Right => new Cell(Head.X + 1, Head.Y, CellType.SnakeHead, ConsoleColor.Red),
                Direction.Left => new Cell(Head.X - 1, Head.Y, CellType.SnakeHead, ConsoleColor.Red),
                Direction.Up => new Cell(Head.X, Head.Y - 1, CellType.SnakeHead, ConsoleColor.Red),
                Direction.Down => new Cell(Head.X, Head.Y + 1, CellType.SnakeHead, ConsoleColor.Red),
                _ => Head
            };
        }

        static Direction ReadMovement(Direction currentDirection)
        {
            if (!Console.KeyAvailable)
                return currentDirection;

            ConsoleKey key = Console.ReadKey(true).Key;

            currentDirection = key switch
            {
                ConsoleKey.UpArrow when currentDirection != Direction.Down => Direction.Up,
                ConsoleKey.DownArrow when currentDirection != Direction.Up => Direction.Down,
                ConsoleKey.LeftArrow when currentDirection != Direction.Right => Direction.Left,
                ConsoleKey.RightArrow when currentDirection != Direction.Left => Direction.Right,
                _ => currentDirection
            };

            return currentDirection;
        }

        //private bool BorderChecker(Field field, Cell currentCell)
        //{
        //    bool isBorder = false;
        //    for (int i = 0; i < field.Cells.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < field.Cells.GetLength(1); j++)
        //        {
        //            if (field.Cells[i, j].X == currentCell.X++ && field.Cells[i, j].Y == currentCell.Y)
        //            {
        //                if (j == 0 || j == field.Cells.GetLength(1) - 1 || i == 0 || i == field.Cells.GetLength(0) - 1)
        //                    isBorder = true;
        //                else
        //                    isBorder = false;
        //            }
        //        }
        //    }
        //    return isBorder;
        //}
    }
}
