using System;


namespace program_to_find_the_perfect_numbers_from_n1_to_n2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Sn, En ,x,y,S;

            Console.WriteLine("Program to find the perfect numbers from n1 to n2");
            Console.WriteLine("--------------------------------------------------\n");

            Console.Write("Start Number = ");
            Sn = double.Parse(Console.ReadLine());

            Console.Write("End Number = ");
            En = double.Parse(Console.ReadLine());

            Console.Write("The Perfect number between {0} and {1} is (",Sn,En);

            for(x=Sn;x<=En;x++)
            {
                S = 0;
                for(y=1;y<x;y++)
                { 
                if(x % y ==0)
                {
                    S = S + y;
                }

                }
                if(S==x)
                Console.Write("{0} ",S);
            }
            Console.WriteLine(")");
            Console.ReadKey();



        }
    }
}
