using System;

namespace First 
{
    internal class Program
    {
        static void Main()
        {
            bool checkInvalid = false;
            double result = 0;
            double test;
            int putere = 0;
            int variables = 0; 
            int value;
            string operation;
            string  line; 
            
            
            Console.WriteLine("Hello World! -> Dani :) \nCate variabile doriti?");
            
            line = Console.ReadLine();

           while (variables == 0)
           {
                if (int.TryParse(line, out value))
                {
                variables = Convert.ToInt32(line);
                } else
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");

                Console.ForegroundColor = ConsoleColor.Gray;
                line = Console.ReadLine();
                }
            }

            double[] numbers = new double[variables];

           for (int i = 0; i < variables; i++)
           {
             int forLoop = i + 1; 

             if (i == 0)
             {
                 Console.WriteLine("Perect! Introdu numarul " + forLoop);
             } else
             {
                 Console.WriteLine("Introdu numarul " + forLoop);
             }


                line = Console.ReadLine();

            while (double.TryParse(line, out test) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                
                Console.ForegroundColor = ConsoleColor.Gray;
                line = Console.ReadLine();
                
            }
               
            numbers[i] = Convert.ToDouble(line);
            }

           Console.WriteLine("Ce vrei sa se intample? Poti alege intre: adunare, scadere, inmultire, impartire, ridicare la putere (raspunsuri separate) sau mediana.");
           operation = Convert.ToString(Console.ReadLine());

          do
          {
               switch (operation)
               {
                   case "adunare":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            result = result + numbers[i];
                        }

                        checkInvalid = false;

                        break;
    
                    case "scadere":
                        for (int i = 1; i < numbers.Length; i++)
                        {
                            result = numbers[0];
    
                            result = result - numbers[i];
                        }

                        checkInvalid = false;

                        break;
                        
                    case "inmultire":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                           if (result != 0)
                           {
                               result = result * numbers[i];
                           } else
                           {
                               result = numbers[0];
                           }
                        }

                        checkInvalid = false;

                        break;
                    
                    case "impartire":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                           if (result != 0)
                           {
                               result = result / numbers[i];
                           } else
                           {
                               result = numbers[0];
                           }
                        }

                        checkInvalid = false;

                        break;
    
                    case "ridicare la putere":
    
                     
                     checkInvalid = false;
    
                     Console.WriteLine("Puterea a ...");
                     line = Console.ReadLine();

                        while (int.TryParse(line, out value) == false)
                        {
                         Console.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("Invalid");
                
                        Console.ForegroundColor = ConsoleColor.Gray;
                         line = Console.ReadLine();
                
                         }

                     putere = Convert.ToInt32(line);
    
                     Console.ForegroundColor = ConsoleColor.Green;
    
                         for (int i = 0; i < numbers.Length; i++)
                         {
                           double raspuns = Math.Pow(numbers[i], putere);
                           Console.WriteLine(numbers[i] + " ridicat la puterea a " + putere + " = " + raspuns);
                         }

                         Console.ForegroundColor = ConsoleColor.Gray;

                        break;
    
                    case "mediana":
                    
                         for (int i = 0; i < numbers.Length; i++)
                        {
                            result = result + numbers[i];
                        }
                        
                        result = result / variables;

                        checkInvalid = false;
    
                        break;
    
                    default:
                        Console.ForegroundColor = ConsoleColor.Red; 
                        Console.WriteLine("Invalid! Reincearca");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        operation = Convert.ToString(Console.ReadLine());

                        checkInvalid = true;
                        break;
                   
               }
          } while (checkInvalid == true);
           
           
           
           if (checkInvalid == false && putere == 0)
           {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("Resultatul este " + result);
               Console.ForegroundColor = ConsoleColor.Gray;
           }

        Console.WriteLine("Din nou?   Da/Nu");
        line = Console.ReadLine();

       while (true)
       {
            if (line == "Da")
            {
                Console.Clear();
    
                First.Program.Main();
            } else if (line == "Nu")
            {
                return;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine("Invalid! Reincearca");
                Console.ForegroundColor = ConsoleColor.Gray;

                line = Console.ReadLine();

            }
       }

        Console.ReadKey();

        }


    }

}