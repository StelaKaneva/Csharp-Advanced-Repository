using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            this.Capacity = capacity;
            this.Name = name;
            this.data = new List<Rabbit>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.data.Count;

        public void Add(Rabbit rabbit)
        {
            if (Capacity > this.data.Count)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbitToBeRemoved = this.data.FirstOrDefault(r => r.Name == name);

            if (rabbitToBeRemoved != null)
            {
                data.Remove(rabbitToBeRemoved);
                return true;
            }

            return false;
        }

        public void RemoveSpecies(string species)
        {
            data = this.data.Where(r => r.Species != species).ToList();
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabitForSale = this.data.FirstOrDefault(r => r.Name == name);

            rabitForSale.Available = false;
            return rabitForSale;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbitsForSale = this.data.Where(r => r.Species == species).ToArray();

            for (int i = 0; i < this.data.Count; i++)
            {
                if (this.data[i].Species == species)
                {
                    this.data[i].Available = false;
                }
            }

            return rabbitsForSale;
        }

        public string Report()
        {
            List<Rabbit> rabbits = this.data.Where(r => r.Available == true).ToList();

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Rabbits available at {this.Name}:");
            foreach (var rabbit in rabbits)
            {
                result.AppendLine(rabbit.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
