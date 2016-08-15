using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DiscoverMe;

namespace ILLabor
{
    public class Program
    {
        //public delegate void StringWriter(object target);

        public delegate List<int> AddToList(List<int> list, int value);
        static void Main(string[] args)
        {
            //GenerateStringWriterFor(new Person(2010));
            AddToList generated = GenerateAddToList();

            var list = new List<int>();
            generated(list, 1);
            generated(list, 0);
            generated(list, -2);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        private static AddToList GenerateAddToList()
        {
            DynamicMethod writer = new DynamicMethod("AddToList", 
                typeof(List<int>), new[] { typeof(List<int>), typeof(int) });
            MethodInfo addMethod = typeof(List<int>).GetMethod("Add");

            var gen = writer.GetILGenerator();
            var retLabel = gen.DefineLabel();

            gen.Emit(OpCodes.Ldarg_1);
            gen.Emit(OpCodes.Ldc_I4_0);
            gen.Emit(OpCodes.Blt, retLabel);

            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldarg_1);
            gen.Emit(OpCodes.Call, addMethod);

            gen.MarkLabel(retLabel);
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ret);
            return (AddToList)writer.CreateDelegate(typeof(AddToList));
        }

        //private static void GenerateStringWriterFor(object target)
        //{
        //    DynamicMethod writer = new DynamicMethod("PersonWriter", typeof(void), new[] { typeof(object) });

        //    MethodInfo writeString = typeof(Console).GetMethod("WriteLine", new[] { typeof(string) });

        //    Type targetType = target.GetType();
        //    var gen = writer.GetILGenerator();

        //    foreach (var member in targetType.GetFields())
        //    {
        //        gen.Emit(OpCodes.Ldarg_0);
        //        gen.Emit(OpCodes.Castclass, targetType);
        //        gen.Emit(OpCodes.Ldfld, member);
        //        gen.Emit(OpCodes.Pop);

        //    }

        //    gen.Emit(OpCodes.Ret);
        //    StringWriter generated = (StringWriter)writer.CreateDelegate(typeof(StringWriter));
        //    generated(target);
        //}
    }
}
