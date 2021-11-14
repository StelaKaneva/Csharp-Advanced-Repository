using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsDemo
{
    class Dog
    {
        private int bitenPeopleCount;
        private string firstName;
        private string lastName;
        private int age;
        public string Name { get; set; }

        public string FullName
        {
            get { return firstName + " " + lastName; }
            set
            {
                var split = value.Split();
                firstName = split[0];
                lastName = split[1];
                ;
            }
        }
        public int Age
            {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ne moje ade < 0");
                }
                else if (value > 100)
                {
                    throw new ArgumentException("Ne e vuzmojno");
                }

                age = value;
                ;
            }
        }

        public bool IsBadDog
        {
            get { return bitenPeopleCount >= 2; }
        }

        public void BitenPerson()
        {
            bitenPeopleCount++;
        }
    }
}
