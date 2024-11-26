using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators1
    {
       
 

    
    
        public class Program
        {
            static void Main(string[] args)
            {
                int a = 10; int b = -20;
                Console.WriteLine("Addition of :" + (a + b));
                Console.WriteLine("multiplication :" + (b * a));
                Console.WriteLine("Substraction :" + (a - b));
                Console.WriteLine("Devision :" + (a / b));
                Console.WriteLine("Module :" + (b % a));

                if (a > 0 && b > 0)
                {
                    Console.WriteLine("Both are positive no");
                }
                else
                {
                    Console.WriteLine("one is negative");
                }
                if (a > 0 || b < 0)
                {
                    Console.WriteLine("Either a is positive or b is negative");
                }
                //else(a!=0 )
                //{
                //  Console.WriteLine("a or are not positive");
                //}

                int number = 5;
                number += 12;
                Console.WriteLine(number);


                int number1 = 5;
                number1 -= 10;
                Console.WriteLine(number1);


                int number2 = 5;
                number2 /= 10;
                Console.WriteLine(number2);


                int number3 = 5;
                number3 *= 10;
                Console.WriteLine(number3);


                int number4 = 5;
                number4 %= 10;
                Console.WriteLine(number4);





                //int number1 = 10;
                //number1++;
                //Console.WriteLine(number1);

                //int number2 = 100;
                //number2++;
                //Console.WriteLine(number2);


            }
        }
    }





    

