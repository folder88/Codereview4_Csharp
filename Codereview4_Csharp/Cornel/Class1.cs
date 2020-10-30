using System;
using System.Collections.Generic;
using System.Text;

namespace Codereview4_Csharp.Cornel
{
    class Class1
    {

        
        public void method2(string name)

        {

            Console.WriteLine($"Hi {name} how are you today");
            Console.WriteLine("Press 1 and Enter for: busy but ok;)\nPress 2 and Enter for:never been better :D\nPress 3 and Enter for:pretty good thanks");
            string answer2 = Console.ReadLine();

            if(answer2 == "1")
            {
                method2a();
            }
            else if(answer2 == "2")
            {
                method3();
            }
            else if (answer2 == "3")
            {
                method3();
            }

        }

        public void method2a()
        {
            Console.WriteLine("Great!would you like to use our express-delivery service?\nPress 1 for:sounds good\nPress 2 for:no hurry");
            string answer2a = Console.ReadLine();

            if (answer2a == "1")
            {
                method4();
            }
            else if(answer2a == "2")
            {
                method3();
            }
        }
        public void method3()

            
        {
            Console.WriteLine("would you like to order some food?\nPress 1 for:not yet,just wanted to chat\nPress 2 for:yes please");
            string answer3 = Console.ReadLine();
            if (answer3 == "1")
            {
                Console.WriteLine("Have a nice day");
            }
           else if (answer3 == "2")
            {
                method4();
            }

        }

        public void method4()
        {
            Console.WriteLine("What type of pizza would you like?\nPress 1 for:Pizza romana\nPress 2 for:Pizza diavola\nPress 3 for:Pizza tonna\nPress 5 for:Pizza formaggio\nPress 6 for:Pizza margherita");
            string pizza = Console.ReadLine();
            Console.WriteLine("what size?\nPress 1 for:small\nPress 2 for:big\nPress 3 for:super-big family pizza");
            string answer5 = Console.ReadLine();
            Console.WriteLine("Would you like to add some drinks to your order?\nPress 1 for:yes please\n2:no,thanks");
            string answer6 = Console.ReadLine();
            if(answer6 == "1")
            {
                method6a();
            }
            else if(answer6 == "2")
            {
                method7();
            }

        }
        public void method6a() {
            Console.WriteLine("1:Bear\n2:Cola\nJuice");
        }
        public void method7()
        {
         
        }
    }
}
