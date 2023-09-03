// See https://aka.ms/new-console-template for more information
using System;

namespace Organization
{
    internal class Program
    {

        public int speed;
        public string color;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int time = 9;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            Program MyObj = new Program();

            MyObj.speed = 1;

            MyObj.color = "red";
            
            string x = Console.ReadLine();

            x = x.ToString();

            char[] x_array= x.ToArray();

            Console.WriteLine(x_array.Length);
            Console.WriteLine(x_array);




        }
    }
}




