using SnakeGame.Models;
using System.Runtime.Versioning;
namespace SnakeGame
{
    [SupportedOSPlatform("windows")]
    internal class Game
    {
        Field field = new Field(Program.FieldHeight, Program.FieldWidth);
        private bool _gameRunning;

        public Game()
        {
            _gameRunning = true;
        }

        public void Start()
        {
            field.DrawBorders();
            while (_gameRunning)
            {
                try
                {
                    Draw();
                    Update();
                }
                catch (ArgumentOutOfRangeException)
                {
                    _gameRunning = false;
                    field.ClearFood();
                    foreach (var cell in field.TheEndLabel)
                    {
                        cell.X -= 2;
                        cell.FontCellDraw();
                    }
                }
            }
        }

        private void Draw()
        {
            field.Snake.Draw();
            Thread.Sleep(400);
            field.Snake.Clear();
        }

        private void Update()
        {
            field.Snake.Move(field, ref _gameRunning);
        }

    }
}
