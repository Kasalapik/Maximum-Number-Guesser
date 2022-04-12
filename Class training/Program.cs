using System;
using System.Collections.Generic;
using System.Linq;

namespace Class_training
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            int a;
            List<int?> listok = new List<int?>();
            string input1;
            Console.WriteLine("Which number is higher, input numbers");
            int counter = 0;
            int b;
            do
            {
                input1 = Console.ReadLine();
                if ((string.IsNullOrEmpty(input1)) == true)
                {
                    counter++;
                }
                else
                {
                    a = Convert.ToInt32(input1);
                    listok.Add(a);
                }
                
            }
            while (counter < 1);


            //Console.WriteLine(listok.ToString());
            Console.WriteLine(string.Join(", ", listok));

            var mc = new MaxNumFunc();
            a = (int)listok[0];

            for (int i = 0; i < listok.Count(); i++ )
            {
                b = (int)listok[i];

                mc.MaxNum(a, b);

                a = mc.MaxR;
            }

            Console.WriteLine(a);





        }
    }
}
