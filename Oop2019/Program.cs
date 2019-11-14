using DocumentFormat.OpenXml.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2019
{
    class Program
    {

        static void Main(string[] args)
        {


            ////Exercise 1     Klar   
            ///
            //Console.WriteLine("Write in your number");
            //var num = Console.ReadLine();
            //int result1;
            //while (!int.TryParse(num, out result1))
            //{
            //    Console.WriteLine("This is not a number! try again");
            //    num = Console.ReadLine();
            //}
            //Console.WriteLine("Write one more number");
            //var num2 = Console.ReadLine();
            //int result2;
            //while (!int.TryParse(num2, out result2))
            //{
            //    Console.WriteLine("This is not a number! try again");
            //    num2 = Console.ReadLine();
            //}
            //Console.WriteLine($"Your number is: {num} + {num2} = {result1 +result2}");
            //Console.ReadLine();


            //Exercise 2 Klar

            //int year1;
            //int year2;

            //Console.WriteLine(" -- Amazing leap year calculator -- ");

            //Console.WriteLine("First year must be between 0 - 9999");
            //year1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("First year is :" + year1);

            //Console.WriteLine("Second year must be between " + year1 + " - 9999");
            //year2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Second year is :" + year2);


            //for (int i = year1; i <= year2; i++)
            //{
            //    if (DateTime.IsLeapYear(i))
            //    {
            //        Console.WriteLine("{0} *", i);
            //    }
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();


            //Exercise 3 Klar

            //bool palindrome = false;
            //string str1, str2 = string.Empty;
            //Console.Write("Enter a word :");
            //str1 = Console.ReadLine();
            //if (str1 != null)
            //{              
            //    for (int i = str1.Length - 1; i >= 0; i--)
            //    {
            //        str2 += str1[i].ToString();
            //    }
            //    if (str2 == str1)
            //    {
            //        Console.WriteLine("the word is: {0} and it is true", str1, str2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("the Input is: {0} and it is false", str1, str2);
            //    }                          
            //}
            //Console.ReadLine();
            //Console.WriteLine(" good job!!!");

            //Exercise 4 Klar

            //for( int i = 0; i<=100; i++)
            //{

            //    if (i % 3 == 0 && i % 5 == 0)

            //    {
            //        Console.WriteLine("fizz" );
            //    }
            //    else if (i % 3 == 0)

            //    {
            //        Console.WriteLine("buzz");
            //    }
            //     else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("fizzbuzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.ReadLine();

            //Exercise 5 Klar

            //bool run = true;

            //while(run)
            //{
            //var random = new Random();
            //var number = random.Next(1, 100);          
            //int num;
            //Console.WriteLine("Guess a number between 1-99");
            //num = Convert.ToInt32(Console.ReadLine());
            //    bool correct = false;
            //while (!correct) { 
            //if (num == number)
            //{
            //    Console.WriteLine("It is the correct number");
            //            break;
            //}
            //else if ( num >number)
            //{
            //    Console.WriteLine("your number is wrong is to big. Guess agien");
            //    num = Convert.ToInt32(Console.ReadLine());
            //}
            //else if (num < number)
            //{
            //    Console.WriteLine("number to small. Guess agien");
            //    num = Convert.ToInt32(Console.ReadLine());
            //}
            //else if (num>100 && num<1)
            //    {
            //        Console.WriteLine("your number should be between 1-99");
            //    }
            //}
            //}
            //Console.ReadLine();

            //Exercise 6  inte färdig måste titta på denna igen. 

            //bool run = true;
            //Console.WriteLine("----You VS AI---- \n\n");
            //while (run)
            //{
            //    var random = new Random();
            //    var number = random.Next(1, 100);
            //    int num;

            //    int aiNum;
            //    int maxNum = 100;
            //    int minNum = 1;

            //    Console.WriteLine("Guess a number between 1-99");
            //    num = Convert.ToInt32(Console.ReadLine());

            //    bool correct = false;
            //    while (!correct)
            //    {
            //        if(!correct) {
            //              if(num == number)
            //            {
            //            Console.WriteLine("It is the correct number you win");
            //            break;
            //            }
            //             if (num > number)
            //            {
            //                Console.WriteLine("your number is wrong is to big. Guess agien");
            //                num = Convert.ToInt32(Console.ReadLine());
            //            }
            //            else if (num < number)
            //            {
            //                Console.WriteLine("number to small. Guess agien");
            //                num = Convert.ToInt32(Console.ReadLine());
            //            }
            //            else if (num > maxNum && num < minNum)
            //            {
            //                Console.WriteLine("your number should be between 1-99");
            //            }

            //        }
            //        else { 
            //        Console.WriteLine("AI guessed:");
            //        aiNum = Convert.ToInt32(Console.ReadLine());

            //        if (aiNum == number)
            //        {
            //            Console.WriteLine("It is the correct number Ai winns");
            //            break;
            //        }
            //        else if (aiNum > number)
            //        {
            //            Console.WriteLine("Ai number is wrong is to big. Guess agien");
            //            aiNum = Convert.ToInt32(Console.ReadLine());
            //        }
            //        else if (aiNum < number)
            //        {
            //            Console.WriteLine("Ai number to small. Guess agien");
            //            aiNum = Convert.ToInt32(Console.ReadLine());
            //        }
            //        else if (aiNum > maxNum && num < minNum)
            //        {
            //            Console.WriteLine("Ai number should be between 1-99");
            //        }

            //        }

            //    }
            //}
            //Console.ReadLine();


            //Exercise 7 inte helt klar misslyckad än så länge. 
            //var random = new Random();
            //var color = random.Next(8, 16);
            //int width = Console.WindowWidth;

            //Console.BackgroundColor = (ConsoleColor)color;

            ////foreach (ConsoleColor colors in Enum.GetValues(typeof(ConsoleColor)))
            ////{
            ////    Console.BackgroundColor = colors;
            ////    Console.WriteLine(" ");
            ////}
            //while (true)
            //{
            //    for (int i = 0; i < width; i++)
            //    {
            //        Console.WriteLine("*");
            //    }
            //    color = random.Next(8, 16);
            //    Console.ForegroundColor = (ConsoleColor)color;
            //}
            //Console.ReadLine();


            //exercise 8 klar.


            //Console.Write("input size of christmas tree : ");          
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\n\n");
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int y = rows; y >= i; y--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int x = 1; x <= i; x++)
            //    {
            //        Console.Write(" " + "*");

            //    }              
            //    Console.WriteLine();
            //}


            //for (int i = 1; i <= 1; i++)
            //{

            //    for (int j = 0; j < rows; j++)
            //        Console.Write(" ");

            //    for (int j = 1; j <= 1; j++)
            //        Console.Write("[]");

            //   Console.Write("\n");
            //}

            //Console.ReadLine();

            //exercise 9 funkar inte alls. 


            //var data = File.ReadLines(@"C:\Users\eu\source\repos\Oop2019\Oop2019\map.txt");
            //var land = LandTiles(data);

            //Console.WriteLine($"Number of land tiles in map: {land}");
            //Console.ReadKey();



            //exercise 10 inte så lyckad heller. får komma tillbaka till denna med. 

            ////int[] arr;

            //var invader = new[,]
            // {
            // { 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0 },
            // { 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0 },
            // { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
            // { 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0 },
            // { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            // { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
            // { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
            // { 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0 }
            //};
            //var height = invader.GetLength(0);
            //var width = invader.GetLength(1);

            //for (int i =0; i <height; i++)
            //{
            //    for(int x =0; x<width; x++)
            //    {
            //        if (invader[i,x] == 1) 
            //        {
            //            Console.WriteLine("##");
            //        }
            //        else
            //        {
            //            Console.WriteLine("**");
            //        }                                                  
            //    }
            //    break ;
            //}
            //Console.ReadLine();

            //exercise 11
            Calculator();

            static void Calculator() {

            var formula = "1 + 2 * 3";
            var result = CalculateString(formula);
            Console.WriteLine("{0} = {1}", formula, result);
            }
            public static int CalculateString(string formula)
            {

                int result;
            Console.WriteLine("---Calculater--- \n\n");

            Console.WriteLine("type in your number:");
            double value =Convert.ToDouble (Console.ReadLine());





                //exercise 12 och 13.........



            }
        }
    }
}
