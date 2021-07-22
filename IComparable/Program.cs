﻿using System;
using System.IO;
using System.Collections.Generic;
using IComparablee.Entities;

namespace IComparablee
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\antonio.marques\Documents\C#\IComparable\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
