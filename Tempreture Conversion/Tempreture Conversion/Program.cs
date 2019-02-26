using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempreture_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double userTempreture;
            double userFTemp;
            double userCTemp;
            int userChoice;
            bool exitProgram = false;

            do
            {
                Console.Clear();
                Console.Write("Please enter your chosen tempreture: ");
                userTempreture = Convert.ToDouble(Console.ReadLine());
                userFTemp = (userTempreture * 1.8) + 32;
                userCTemp = (userTempreture - 32) / 1.8;

                Console.WriteLine("Conversion Menu:");
                Console.WriteLine("1. Convert from Fahrenheit to Celcius");
                Console.WriteLine("2. Convert from Celcius to Fahrenheit");
                Console.WriteLine("3. Exit Program");
                Console.WriteLine();
                Console.Write("Please choose an option: ");
                userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Tempreture: {0} Celcius", userCTemp);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Tempreture: {0} Fahrenheit", userFTemp);
                        Console.ReadLine();
                        break;
                    case 3:
                        exitProgram = true;
                        break;

                }
            } while (!exitProgram);
            
                Console.ReadKey();
            
                
           
           




            }


  


        }
    }

