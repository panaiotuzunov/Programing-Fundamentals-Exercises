﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            int age = 27;
            char gender = 'f';
            string id = "8306112507";
            string uniqueNumber = "27563571";

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", id);
            Console.WriteLine("Unique Employee number: {0}", uniqueNumber);
        }
    }
}
