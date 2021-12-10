using _SharedSources1.world;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!2");
            int y = Class2.foo(5, 6);
            Console.WriteLine("Hello World!2  "+y );
            Console.WriteLine("Hello World!3  "+y+2 );
        }
		
		void fun(){
			 Console.WriteLine("Hello World!2  " );
		}
	    void fun_world(){
			 Console.WriteLine("Hello World!3 " );
		}
	    
    }
}
