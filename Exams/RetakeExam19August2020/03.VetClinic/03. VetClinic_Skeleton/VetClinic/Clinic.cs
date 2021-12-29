using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;

        public Clinic(int capacity)
        {
            data = new List<Pet>();
            this.Capacity = capacity;
        }

        public int Capacity { get; set; }

        public int Count => data.Count;
        public void Add(Pet pet)
        {
            if (data.Count < Capacity)
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet petToBeRemoved = this.data.FirstOrDefault(p => p.Name == name);

            if (petToBeRemoved != null)
            {
                data.Remove(petToBeRemoved);
                return true;
            }

            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            Pet petToBeFound = this.data.FirstOrDefault(p => p.Name == name && p.Owner == owner);

            return petToBeFound;
        }

        public Pet GetOldestPet()
        {
            Pet oldestPet = this.data.OrderByDescending(p => p.Age).FirstOrDefault();

            return oldestPet;
        }

        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("The clinic has the following patients:");

            foreach (var pet in data)
            {
                result.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
