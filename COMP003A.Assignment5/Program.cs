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
            ///<summary> Add the titles for different topic in the () to make headers for different sections</summary>
            Console.WriteLine($"Enter a single character: ");
            char inputCharacter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Enter a positive whole number: ");
            int size = Convert.ToInt32(Console.ReadLine());
            
            IsoscelesTriangleBuilder(inputCharacter, size);

            PrintSeparator();
            PrintSeparator("Favorite Characters");
            PrintSeparator();

            CharacterInfo("Spider-Man", 1962);
            CharacterInfo("Simon the Digger", 2007);
            CharacterInfo("Percy Jackson", 1993);
            CharacterInfo("Straw-Hat Luffy", 1997);
            CharacterInfo("Mobile Suit RX-78", 1979);
            
        }

        static void PrintSeparator() { Console.WriteLine("".PadRight(50, '*')); }
        static void PrintSeparator(string topic) { Console.WriteLine(topic); }

        static string IsoscelesTriangleBuilder(char inputCharacter, int size)
        {

            string topTriangle = Char.ToString(inputCharacter);
                for (int i = 0; i < size; i++)
            {

                Console.WriteLine(topTriangle);
                topTriangle += ($"{inputCharacter}");
                
            }
                ///<summary>
                ///The topTriangle string converts the original char input into a string. Then that new string get's looped from 0- int size, adding the chosen char again after each loop.
                ///</summary>
                for (int j=size-1;j>0; j--)
            {
                string bottomTriangle = topTriangle.Substring(0, j);
                Console.WriteLine(bottomTriangle);

            }
                return topTriangle;
            ///<summary>
            ///Creates a substring from the last line of the previous loop. It then loops itself, substringing one less character at a time until it reaches 1.
            /// </summary>
        }

        static int AgeCalculator(int year)
        {  
            int age= 2024 - year;
            return age;
            ///<summary> Input the year the character was born and it will return their current age</summary>
            
        }
        static string CharacterInfo(string name, int birthYear)
        {
            string characterName = name;
            AgeCalculator(birthYear);
            string characterInfo=($"I am {characterName}, and I am {Convert.ToString(AgeCalculator(birthYear))} years old");
            Console.WriteLine(characterInfo);
            return characterInfo;
            ///<summary> After inputing a name and birthyear, this will give an output of a character introducing themselves.</summary>
        }


    }
}
