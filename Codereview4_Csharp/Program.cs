using Codereview4_Csharp.Cornel;
using System;
using System.Runtime.CompilerServices;

namespace Codereview4_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            method3();
        }

        static void method3()
        {
            Console.WriteLine(" Hi whats your name? \n\n Press 1 and Enter: for entering your name \n Press 2 and Enter: for i dont talk to strangers");
            
            string answer = Console.ReadLine();

            if(answer == "1")
            {

                Class1 task_01 = new Cornel.Class1();
                Console.WriteLine("Whats your name?");
                string name = Console.ReadLine();
 
                task_01.method2(name);
                

                


                
                
            }
            else if(answer == "2")
            {
                Console.WriteLine("Have a nice Day!");
            }
            

        }
    }
}
