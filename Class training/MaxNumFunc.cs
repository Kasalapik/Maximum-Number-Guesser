using System;
using System.Collections.Generic;
using System.Text;

namespace Class_training
{
    public class MaxNumFunc
    {


        public int MaxR;



        public void MaxNum(int a, int b) 
        { 
        if (a>=b)
            {
                MaxR = a;
                
            }
        if (b > a)
            {
                MaxR = b;
                
            }
        else
            {
                Console.WriteLine("Error");
                

            }


        }
    }
        


}

