using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverMe
{
    public class Person
    {
        public int BirthYear { get; set; }

        public int Age { get { return DateTime.Now.Year - BirthYear; } }

        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public Person()
        {
            BirthYear = DateTime.Now.Year - 20;
        }

        public Person(int birthYear)
        {
            BirthYear = birthYear;
        }
    }
}
