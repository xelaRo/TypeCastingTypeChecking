namespace TypeCasting
{
    public class TypeConversion
    {
        //char -> int -> long -> float -> double
        public void ImplicitConversion()
        {
            int i = 10;
            long l = i;
            double d = l;


            Console.WriteLine($"Value of i is {i}");
            Console.WriteLine($"Value of l is {l}");
            Console.WriteLine($"Value of d is {d}");
        }

        public void ExplictConversion()
        {
            double d = 24.65;
            int i = (int)d;

            Console.WriteLine($"Value of d is {d}");
            Console.WriteLine($"Value of i is {i}");
        }

        public void ExplicitConversionOrNullable()
        {
            string str = "String to be converted";

            //assign variable str
            //to object type variable
            object obj = str;
            
            //try to cast obj variable to string
            string str2 = obj as string;

            //check if str2 variable is null
            if(str2 != null)
            {
                Console.WriteLine($"Successful conversion of {nameof(obj)} to {nameof(str)}");
            }
            
            //try to cast obj to a dictionary
            Dictionary<string, object> dict = obj as Dictionary<string, object>;


            //check if dict variable si null
            if (dict != null)
            {
                Console.WriteLine($"Successful conversion of {nameof(obj)} to {nameof(dict)}");
            }
            else
            {
                Console.WriteLine($"Not Successful conversion of {nameof(obj)} to {nameof(dict)}");
            }
        }
    }

  
}
