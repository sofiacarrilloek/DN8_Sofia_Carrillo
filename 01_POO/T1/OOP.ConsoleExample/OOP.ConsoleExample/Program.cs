﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace OOP.ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            Animal animal = new Animal();
            animal.AnimalSound();

            Console.ReadKey();
        }
    }
}
