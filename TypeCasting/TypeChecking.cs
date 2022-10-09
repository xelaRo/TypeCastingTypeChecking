using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class TypeChecking
    {

        public void IsTypeCheckingOperator()
        {
            object obj = null;
            
            if(obj is null)
            {
                Console.WriteLine("The obj variable value is null");
            }

            object parent = new Parent();
            object child = new Child();

            Console.WriteLine($"The {nameof(parent)} variable is of type {nameof(Parent)}: {parent is Parent}" );
            Console.WriteLine($"The {nameof(parent)} variable is of type {nameof(Parent)}: {parent is Child}");
           
            Console.WriteLine($"The {nameof(child)} variable is of type {nameof(Child)}: {child is Child}");
            Console.WriteLine($"The {nameof(child)} variable is of type {nameof(Parent)}: {child is Parent}");
        }

        public void TyoeOfOperator()
        {
            Console.WriteLine($"{typeof(int)}");
            Console.WriteLine($"{typeof(object)}");
            Console.WriteLine($"{typeof(string)}");
            Console.WriteLine($"{typeof(Parent)}");
            Console.WriteLine($"{typeof(Child)}");
            Console.WriteLine($"{typeof(Dictionary<string,string>)}");
        }
    }

    internal class Parent
    {
      
    }

    internal class Child : Parent
    {
       
    }
}
