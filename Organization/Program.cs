// See https://aka.ms/new-console-template for more information
using System;

namespace Organization
{
    internal class Program
    {

        //public int speed;
        //public string color;

        public static List<int> lol = new List<int>();
        public static List<char> lol_char = new List<char>();
        public static List<int> lol_int = new List<int>();

        static void Main(string[] args)
        {
    //            Console.WriteLine("Hello World!");
    //            int time = 9;
    //            string result = (time < 18) ? "Good day." : "Good evening.";
    //            Console.WriteLine(result);
    //            //Program MyObj = new Program();
    //            //MyObj.speed = 1;
    //            MyObj.color = "red";
    //            string x = Console.ReadLine();
    //            x = x.ToString();
    //            char[] x_array= x.ToArray();
    //            Console.WriteLine(x_array.Length);
    //            Console.WriteLine(x_array[1]);
    //            string bazString = @"Here's some stuff
    //on a new line! ""Wow!"", the masses cried";
    //            Console.WriteLine(bazString);
    //            Console.WriteLine(2+1/2);



            Rate_Law();
        }
        public static void Rate_Law()
        {
            Console.WriteLine("list moment");
            string a = Console.ReadLine();
            //Console.WriteLine("repeated");
            //string b = Console.ReadLine();
            //Console.WriteLine("repeated");
            //string c = Console.ReadLine();

            foreach (char i in a)
            {

                if (i - '0' >= 0)
                {
                    lol.Add(i - '0');
                }
            }

            int lol_amount = lol.Count;
            int ppp = 0;
            Console.WriteLine(lol_amount);
            int uppercase = 32;

            while(ppp < lol_amount)
            {
                if (lol[ppp] < 10)
                {
                    Console.WriteLine(lol[ppp]);
                    lol_int.Add(lol[ppp]);
                }
                else 
                {
                    Console.WriteLine("h moment : " + (char)(lol[ppp]+16+(uppercase)));
                    lol_char.Add((char)(lol[ppp] + 16 + (uppercase)));
                }

                
            ppp++;

            }
         

            lol_int.ForEach(p => Console.Write(p+",")); Console.WriteLine();
            lol_char.ForEach(p => Console.Write(p + ",")); Console.WriteLine();
            lol_int.Sort();
            lol_char.Sort();
            lol_int.ForEach(p => Console.Write(p + ",")); Console.WriteLine();
            lol_char.ForEach(p => Console.Write(p + ",")); Console.WriteLine();


            //foreach (char i in b)
            //{

            //    if ((i - '0') >= (0) )
            //    {
            //        Console.WriteLine("your ints were 0:"+ i);

            //    }
            //    else
            //    {
            //        Console.WriteLine("these aren't ints :" + i);
            //    }
            //}

            //foreach (char i in c)
            //{

            //    if (i - '0' >= 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



        }
    }
}




