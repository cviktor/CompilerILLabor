using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILLabor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Béla", Age = 23 };
            Child c = new Child { Name = "Ödönke", Age = 10, FavoriteToy = "Pokemon GO" };

            //A példány osztályának metaadatait egy Type osztály reprezentálja.
            Type personType = p.GetType();
            Type childrenType = c.GetType();

            Console.WriteLine(personType.FullName);
            Console.WriteLine(childrenType.FullName);

            WriteBaseClasses(childrenType);

            Console.ReadKey();
        }

        static void WriteBaseClasses(Type type)
        {
            while (type != null)
            {
                Console.Write(type.FullName + " -> ");
                type = type.BaseType;
            }
            Console.WriteLine();
        }
    }
}
