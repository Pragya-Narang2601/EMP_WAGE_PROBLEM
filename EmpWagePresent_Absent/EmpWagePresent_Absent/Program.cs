﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagePresent_Absent
{
    class Program
    {
        static void Main(string[] args)
        {
           int Is_Full_Time = 1;
           Random random = new Random();
           int empCheck = random.Next(0, 2);
           if (empCheck == Is_Full_Time)
               Console.WriteLine("Employee is Present");
           else
               Console.WriteLine("Employee is Absent");
            Console.ReadKey();

        }
    }
}
