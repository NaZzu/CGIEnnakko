using System;

namespace KoodailuCshrp
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("type exit to exit");
            while (true)
            {
            restart:
                Console.Write("Please enter your business digit:");
                string input = System.Console.ReadLine();
                if (input.Equals("exit"))
                {
                    break;
                }

                BusinessIdSpecification test = new BusinessIdSpecification();
                test.IsSatisfiedBy(input);
                foreach (string errorsDigit in test.ReasonsForDissatisfaction)
                    if (!test.IsSatisfiedBy(input))
                    {
                        Console.Clear();
                        Console.WriteLine(errorsDigit);
                        Console.WriteLine("Please do it right this time");
                        goto restart;
                    }
                Console.Clear();
                Console.WriteLine("You have entered the correct amount of digits");
                Console.WriteLine("Please enter your control mark");

                string control = System.Console.ReadLine();
                test.IsControlOk(control);

                if (control.Equals("exit"))
                {
                    break;
                }


                foreach (string errorsControl in test.ControlMarkDissaatisfaction)
                    if (!test.IsControlOk(control))
                    {
                        Console.Clear();
                        Console.WriteLine(errorsControl);
                        Console.WriteLine("You typed poorly, let's try again from the beginning");
                        goto restart;
                    }
                Console.Clear();
                Console.WriteLine("You typed a correct BusinessID!");
                Console.WriteLine("Well done lad, press any key to exit");
                Console.ReadLine();
                break;
                }
            }

        }

    }




