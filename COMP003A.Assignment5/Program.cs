/*Author: Logan Jones
 * Course: COMP-003A
 * Purpose: Code for Assingment 5 COMP.003A
 */



using System.Net.Sockets;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator();
            PrintSeparator("Triangle Section");
            PrintSeparator();
            ///<sumarry> Add the titles for different topic in the () to make headers for different sections</sumarry>
            IsoscelesTriangleBuilder('$', 10);
            
        }

        static void PrintSeparator() { Console.WriteLine("".PadRight(50, '*')); }
        static void PrintSeparator(string topic) { Console.WriteLine(topic); }

        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            Console.WriteLine($"Enter a single character: "+inputCharacter );
            Console.WriteLine($"Enter a positive whole number: "+ size);
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"{inputCharacter}");
                inputCharacter = inputCharacter += inputCharacter;
                
            }
        }
    }
}
