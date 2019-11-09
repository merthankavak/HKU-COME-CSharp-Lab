using System;

namespace convertingvariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string intString = "456", intString2 = "457";
            int int_var = Convert.ToInt32(intString);
            int int_var2 = int.Parse(intString2);
            float float_var = 10.155F;
            double double_var = 854.32;
            Console.WriteLine("Converting string to int with 'Convert.ToInt32()' Method: " + int_var);
            Console.WriteLine("Converting string to int with 'int.Parse()' Method: " + int_var2);
            Console.WriteLine("Converting float to int with 'Convert.ToInt32()' Method: " + Convert.ToInt32(float_var));
            Console.WriteLine("Converting double to int with 'Convert.ToInt32()' Method: " + Convert.ToInt32(double_var));


        }
    }
}
