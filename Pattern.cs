using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Pattern
    {
        int num { get; set; }

        private void GetNumberFromUser()
        {
            Console.WriteLine("Enter Any Number");
            num = Convert.ToInt32(Console.ReadLine());

        }

        public void StarPattern1()
        {
            GetNumberFromUser();

            for(int i=0; i<num; i++)
            {
                for(int j=0; j<num; j++)   
                Console.Write("*");
                {
                    Console.WriteLine();
                }
            }
        }

        public void StarPattern2()
        {
            GetNumberFromUser();
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                {
                    Console.WriteLine();
                }
            }
        }
        public void StarPattern3()
        {
            GetNumberFromUser();
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                {
                    Console.WriteLine();
                }
            }
        }

        public void StarPattern4()
        {
            GetNumberFromUser();
            for (int i = 1; i <= num; i++)
            {
                for(int k = num - i; k > 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                    Console.Write(" * ");
                {
                    Console.WriteLine();
                }
            }
        }















        //__________----------__________----------__________----------__________----------__________----------


        public static void StaticFunction1()
        {
          
        }

        public static void StaticFunction2() 
        {
            StaticFunction1();
            //object
            Pattern pattern = new Pattern();
            pattern.NonStaticFunction1();

        }

        public void NonStaticFunction1()
        {
            StaticFunction2();
            NonStaticFunction2();

        }

        public void NonStaticFunction2()
        {

        }

//__________----------__________----------__________----------__________----------__________----------

        public static void Pattern1()
        {
            Console.WriteLine();
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    Console.Write(" " + Convert.ToChar(64 + j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("____________________________________________________________");
        }
        public static void Pattern2()
        {
            Console.WriteLine();
            for (int i = 8; i >= 1; i--)
            {
                for (int j = 8; j >= 1; j--)
                {
                    Console.Write(" " + Convert.ToChar(64 + j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("______________________________________________________________");

        }
        public static void Pattern3()
        {
            Console.WriteLine();
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    Console.Write(" " + Convert.ToChar(64 + i));
                }
                Console.WriteLine();
            }
            Console.WriteLine("______________________________________________________________");

        }
        public static void Pattern4()
        {
            Console.WriteLine();
            for (int i = 8; i >= 1; i--)
            {
                for (int j = 8; j >= 1; j--)
                {
                    Console.Write(" " + Convert.ToChar(64 + i));
                }
                Console.WriteLine();
            }
            Console.WriteLine("______________________________________________________________");
        }
        public static void Pattern5()
        {
            Console.WriteLine();
            int k = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(" " + k++);
                }
                Console.WriteLine();
            }
            Console.WriteLine("______________________________________________________________");
        }
        public static void Pattern6()
        {
            Console.WriteLine();
            int k = 9;
            for (int i = 3; i >= 1; i--)
            {
                for (int j = 3; j >= 1; j--)
                {
                    Console.Write(" " + k--);
                }
                Console.WriteLine();
            }
            Console.WriteLine("______________________________________________________________");
        }
        public static void Pattern7()
        {
            Console.WriteLine();
            int k = 1;
            for (int i = 1; i <= 26; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    Console.Write(" " + Convert.ToChar(64 + k++));
                }
                Console.WriteLine();
            }
            Console.WriteLine("______________________________________________________________");
        }
        public static void Pattern8()
        {
            Console.WriteLine();
            int k = 26;
            for (int i = 26; i >= 1; i--)
            {
                for (int j = 7; j >= 1; j--)
                {
                    Console.Write(" " + Convert.ToChar(64 + k--));
                }
                Console.WriteLine();
            }
            Console.WriteLine("______________________________________________________________");

        }

    }
}
