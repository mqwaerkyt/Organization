// See https://aka.ms/new-console-template for more information
using System;

namespace Organization
{
    internal class Program
    {

        public int speed;
        public string color;

        public List<int> lol = new List<int>(); 

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
            Console.WriteLine(x_array[1]);

            string bazString = @"Here's some stuff
on a new line! ""Wow!"", the masses cried";

            Console.WriteLine(bazString);

            Console.WriteLine(2+1/2);



            Rate_Law();
        }
        public static void Rate_Law() 
        {
            Console.WriteLine("h");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string b = Console.ReadLine();

            foreach (char i in a)
            {
                
                if (i-'0' >= 0) 
                {
                    lol.Add(i - '0');
                }
            }

            foreach (char i in b)
            {

                if (i - '0' >= 0)
                {
                    Console.WriteLine(i);
                }
            }

            foreach (char i in c)
            {

                if (i - '0' >= 0)
                {
                    Console.WriteLine(i);
                }
            }

            float f = -1/(2) ;


        }
    }
}




