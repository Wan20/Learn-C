using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switchstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade = 'C';
            switch (grade)
            {
                case 'A':
                Console.WriteLine("Excelleent!");
                break;
                
                case 'B':
                   Console.WriteLine("Good");
                    break;
                case 'C':


                case 'D':
                    Console.WriteLine("You Passed");
                    break;

            }
            Console.WriteLine("Your score is {0}",grade);
            Console.ReadLine();
        }
    };
}
