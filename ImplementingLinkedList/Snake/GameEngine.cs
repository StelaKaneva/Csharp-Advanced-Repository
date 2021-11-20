using Snake.Helper;
using Snake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Snake
{
    public class GameEngine
    {
        private bool isStarted = false;
        private List<IDrawable> gameItems = new List<IDrawable>();
        private Random rand = new Random();
        public Snake Snake { get; set; }

        public GameEngine()
        {
            Snake = new Snake(new Position(30, 20), SpawnFood);
            gameItems.Add(Snake);

            for (int i = 0; i < 20; i++)
            {
                SpawnFood();
                SpawnFood();
                SpawnFood();
            }
        }

        public void Start()
        {
            isStarted = true;
            Position movement = new Position(0, 0);

            while (isStarted == true)
            {
                BoundariesChecker.CheckBoundaries(Snake.SnakeBody.Head.Value, movement);
                
                Snake.Move(movement);

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(false).Key;
                    movement = ReadUserInput.GetMovement(key);
                }

                Thread.Sleep(40);
                //Console.Clear();
                gameItems.ForEach(i => i.Draw());
            }
        }

        public void Stop()
        {
            isStarted = false;
        }

        private void SpawnFood()
        {
            var food = new Food(new Position(rand.Next(0, Console.WindowWidth - 1), rand.Next(0, Console.WindowHeight - 1)));

            gameItems.Add(food);
            Snake.Foods.Add(food);
        }
    }
}
