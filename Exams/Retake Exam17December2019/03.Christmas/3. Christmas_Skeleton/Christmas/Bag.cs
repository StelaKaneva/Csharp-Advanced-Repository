using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> data;

        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            this.data = new List<Present>();
        }

        public string Color { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;

        public void Add(Present present)
        {
            if (Capacity > data.Count)
            {
                data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            Present presentToBeRemoved = this.data.FirstOrDefault(p => p.Name == name);

            if (presentToBeRemoved != null)
            {
                this.data.Remove(presentToBeRemoved);
                return true;
            }

            return false;
        }

        public Present GetHeaviestPresent()
        {
            Present heaviestPresent = this.data.OrderByDescending(p => p.Weight).FirstOrDefault();
            return heaviestPresent;
        }

        public Present GetPresent(string name)
        {
            Present present = this.data.FirstOrDefault(p => p.Name == name);
            return present;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Color} bag contains:");
            foreach (var present in data)
            {
                result.AppendLine(present.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
