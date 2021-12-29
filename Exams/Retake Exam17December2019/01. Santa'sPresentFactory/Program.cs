using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Santa_sPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int[] firstInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] secondInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                Stack<int> valuesOfBoxesWithMaterials = new Stack<int>(firstInput);
                Queue<int> magicValues = new Queue<int>(secondInput);

                Dictionary<string, int> toys = new Dictionary<string, int>();

                bool taskDone = false;

                while (valuesOfBoxesWithMaterials.Any() && magicValues.Any())
                {
                    int material = valuesOfBoxesWithMaterials.Peek();
                    int magic = magicValues.Peek();

                    if (valuesOfBoxesWithMaterials.Peek() == 0 || magicValues.Peek() == 0)
                    {
                        if (valuesOfBoxesWithMaterials.Peek() == 0)
                        {
                            valuesOfBoxesWithMaterials.Pop();
                        }
                        if (magicValues.Peek() == 0)
                        {
                            magicValues.Dequeue();
                        }
                        continue;
                    }

                    int result = material * magic;

                    if (result == 150)
                    {
                        if (!toys.ContainsKey("Doll"))
                        {
                            toys.Add("Doll", 1);
                        }
                        else
                        {
                            toys["Doll"]++;
                        }

                        valuesOfBoxesWithMaterials.Pop();
                        magicValues.Dequeue();
                    }
                    else if (result == 250)
                    {
                        if (!toys.ContainsKey("Wooden train"))
                        {
                            toys.Add("Wooden train", 1);
                        }
                        else
                        {
                            toys["Wooden train"]++;
                        }

                        valuesOfBoxesWithMaterials.Pop();
                        magicValues.Dequeue();
                    }
                    else if (result == 300)
                    {
                        if (!toys.ContainsKey("Teddy bear"))
                        {
                            toys.Add("Teddy bear", 1);
                        }
                        else
                        {
                            toys["Teddy bear"]++;
                        }

                        valuesOfBoxesWithMaterials.Pop();
                        magicValues.Dequeue();
                    }
                    else if (result == 400)
                    {
                        if (!toys.ContainsKey("Bicycle"))
                        {
                            toys.Add("Bicycle", 1);
                        }
                        else
                        {
                            toys["Bicycle"]++;
                        }

                        valuesOfBoxesWithMaterials.Pop();
                        magicValues.Dequeue();
                    }
                    else if (result < 0)
                    {
                        magicValues.Dequeue();
                        valuesOfBoxesWithMaterials.Pop();
                        int materialToPush = magic + material;
                        valuesOfBoxesWithMaterials.Push(materialToPush);
                    }
                    else
                    {
                        magicValues.Dequeue();
                        int materialToBePushed = valuesOfBoxesWithMaterials.Pop() + 15;
                        valuesOfBoxesWithMaterials.Push(materialToBePushed);
                    }
                }

                if (toys.ContainsKey("Teddy bear") && toys.ContainsKey("Bicycle"))
                {
                    taskDone = true;
                }

                if (toys.ContainsKey("Doll") && toys.ContainsKey("Train"))
                {
                    taskDone = true;
                }

                if (taskDone)
                {
                    Console.WriteLine("The presents are crafted! Merry Christmas!");
                }
                else
                {
                    Console.WriteLine("No presents this Christmas!");
                }

                if (valuesOfBoxesWithMaterials.Count > 0)
                {
                    Console.Write("Materials left: ");
                    Console.Write(String.Join(", ", valuesOfBoxesWithMaterials));
                    Console.WriteLine();
                }

                if (magicValues.Count > 0)
                {
                    Console.Write("Magic left: ");
                    Console.Write(String.Join(", ", magicValues));
                    Console.WriteLine();
                }

                foreach (var toy in toys.OrderBy(t => t.Key))
                {
                    Console.WriteLine($"{toy.Key}: {toy.Value}");
                }
            }
    }
}
