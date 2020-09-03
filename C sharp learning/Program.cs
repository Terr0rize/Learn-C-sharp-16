using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{
    
    class Some
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Result is: " + a*b);
        }

        public void Multiply(int a, int b, int c)
        {
            Console.WriteLine("Result is: " + a*b*c);
        }

        public void Multiply(string str)
        {
            Console.WriteLine("Result is: " + str);
        }
    }

    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {         
            Some test = new Some();
            test.Multiply(5, 5);
            test.Multiply(5, 5, 5);
            test.Multiply("Stupid");
            Console.ReadKey();
        }      
    }
}