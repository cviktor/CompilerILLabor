using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILLabor
{
    public class Child : Person
    {
        public string FavoriteToy { get; set; }

        public override void WriteAge()
        {
            Console.WriteLine("Titok");
        }
    }
}
