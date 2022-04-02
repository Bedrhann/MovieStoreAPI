// See https://aka.ms/new-console-template for more information

using System;

namespace deneme0
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.WriteLine(args[0]);

             int x=35;
             //int x = 123;
            //Console.WriteLine( y==2 ? 11111 : 22222 );
            string s = x switch
            {
                <50 => "la 50den köcukmus",
                65  => "65mislaa",
                _   => "bu ne gı"
            };

            switch(x)
            {
                case <50:
              
                    Console.WriteLine("budaoluyo laa");
                    break;

                default:
                break;
                

            }
            //x=y;asdasd
            Console.WriteLine(s+1);

        }
    }
}

