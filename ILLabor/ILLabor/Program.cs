using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DiscoverMe;

namespace ILLabor
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var assembly = Assembly.LoadFrom("DiscoverMe.dll");
            //Console.WriteLine(assembly.FullName + ": " + assembly.Location);

            //foreach (var type in assembly.GetExportedTypes())
            //{
            //    Console.WriteLine(type.Name);
            //    Console.WriteLine("\tPublikus tagok");
            //    foreach (var memberInfo in type.GetMembers())
            //    {
            //        Console.WriteLine($"\t\t{memberInfo.Name}: {memberInfo.MemberType}");
            //    }
            //}


            //Type helloType = typeof(HelloWorld);
            //ConstructorInfo ctor = helloType.GetConstructors()[0];
            //HelloWorld hello = (HelloWorld)ctor.Invoke(new object[0]);
            //hello.WriteHello("BME");

            //Person p = new Person(2010);
            //Type personType = p.GetType();
            //PropertyInfo pi = personType.GetProperty("Age");
            //MethodInfo mi = pi.GetMethod;
            //object age = mi.Invoke(p, new object[0]);
            //Console.WriteLine(age);

            //MethodInfo greetMethod = personType.GetMethod("Greet");
            //ParameterInfo paramInfo = greetMethod.GetParameters()[0];
            //Console.WriteLine($"A {paramInfo.Name} paraméter típusa: {paramInfo.ParameterType.Name}");
            //greetMethod.Invoke(p, new object[] { "BME" });

            Console.ReadKey();
        }
    }
}
