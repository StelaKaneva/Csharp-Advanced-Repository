using Snake.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Food : Interfaces.IDrawable
    {
        private bool isEaten = false;

        public Food(Position position, char symbol = '#')
        {
            this.Position = position;
            this.Symbol = symbol;
        }

        public Position Position { get; set; }
        public char Symbol { get; set; }

        public void EatFood()
        {
            ConsoleHelper.Clear(Position);
            isEaten = true;
        }

        public void Draw()
        {
            if (isEaten == false)
            {
                ConsoleHelper.Write(Position, Symbol.ToString());
            }
            
        }
    }
}
