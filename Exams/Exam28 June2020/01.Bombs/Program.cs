using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> cases = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int datura = 0;
            int cherry = 0;
            int smoke = 0;
            bool pouchFull = false;

            while (effects.Count > 0 && cases.Count > 0)
            {
                if (datura >= 3 && smoke >= 3 && cherry >= 3)
                {
                    pouchFull = true;
                    break;
                }

                int currentEffects = effects.Peek();
                int currentCase = cases.Peek();
                int combined = currentEffects + currentCase;
                bool bombCreated = false;

                if (combined == 40)
                {
                    datura++;
                    bombCreated = true;
                }
                else if (combined == 60)
                {
                    cherry++;
                    bombCreated = true;
                }
                else if (combined == 120)
                {
                    smoke++;
                    bombCreated = true;
                }

                if (bombCreated)
                {
                    effects.Dequeue();
                    cases.Pop();
                }
                else if (currentCase <= 0)
                {
                    cases.Pop();
                }
                else
                {
                    int caseToBeDecreased = cases.Pop() - 5;
                    cases.Push(caseToBeDecreased);
                }

            }

            if (pouchFull)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (cases.Count == 0 && effects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
                Console.WriteLine("Bomb Casings: empty");
                Console.WriteLine($"Cherry Bombs: {cherry}");
                Console.WriteLine($"Datura Bombs: {datura}");
                Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
                return;
            }

            if (effects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {String.Join(", ", effects)}");
            }

            if (cases.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {String.Join(", ", cases)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}
