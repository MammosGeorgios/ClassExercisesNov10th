﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercisesNov10th
{
    class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home("Pirgos", "Saint Pirgos 2000");

            PrintHome print = MethodA;
            print(home);
            
          
            
        }

        public delegate void PrintHome(Home home);

        static void MethodA(Home home)
        {
            Console.WriteLine(home.Name + "-" +home.Address);
        }
    }
   


}

