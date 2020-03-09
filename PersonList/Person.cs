using System;

namespace PersonList
{
    class Person
    {
        private string Name {get; set;}
        private int Age {get; set;}

        public Person(string x)
        {
            Name = x; 
            Age = 18;
        }

        public Person(string x, int y)
        {
            Name = x;
            Age = y;
        }

        public override string ToString()
        {
            return Name;
        }

        public void SetAge(int x)
        {
            Age = x;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

    }
}
