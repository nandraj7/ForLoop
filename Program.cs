
using System.Globalization;

public class Program
{
    public static void Main()
    {
        PrintNumbers();

        PrintNumbers1();

        PrintNumbers2();

        PrintNumbers3();

        NestedLoop();

        NestedLoop1();

        NestedLoop2();

        NestedLoop3();

        NestedLoop4();
    }

    static void PrintNumbers()
    {
        //Print Number From 1 2 3 4...9 10
        Console.WriteLine("Numbers From..");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("______________________________________________ ");
    }
    static void PrintNumbers1()
    {
        //Print Number From 10 9 8...3 2 1
        Console.WriteLine("Numbers From..");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("______________________________________________ ");
    }
    static void PrintNumbers2()
    {
        //Print Number From 10 8 6 4 2 0
        Console.WriteLine("Numbers From..");
        for (int i = 10; i >= 0; i = i - 2)
        {
            Console.WriteLine(i);

        }

        Console.WriteLine("______________________________________________ ");
    }
    static void PrintNumbers3()
    {
        //Q print numbers from 6 12 18 24 30.....60
        Console.WriteLine("Numbers From..");
        for (int i = 6; i <= 60; i = i + 6)
        { 
            Console.WriteLine(i);

        }

        //Console.WriteLine("-------------------------------------------------------------------");
    }
    static void NestedLoop()
    {
        Console.WriteLine("Numbers From..");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("______________________________________________ ");
    }
    static void NestedLoop1()
    {
        Console.WriteLine("Numbers From..");
        for (int i = 1; i <= 5; i++)                //rows
        {

            for (int j = 5; j >= 1; j--)            //columns
            {
                Console.Write(i);
            }

            Console.WriteLine();

        }
        Console.WriteLine("______________________________________________ ");
    }
    static void NestedLoop2()
    {
        Console.WriteLine("Numbers From..");
        for (int i = 5; i >= 1; i--)                //rows
        {

            for (int j = 1; j <= 5; j++)            //columns
            {
                Console.Write(i);
            }

            Console.WriteLine();

        }
        Console.WriteLine("______________________________________________ ");
    }

    static void NestedLoop3()
    {
        for (int i=1; i<=5; i++)
        {
            for (int j=1; j<=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("______________________________________________ ");
    }

    static void NestedLoop4()
    {
        for ( int i=5; i>=1; i--)
        {
            for (int j=1; j<=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("______________________________________________ ");
    }

}
