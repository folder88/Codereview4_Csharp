using System;
using System.Collections.Generic;
using System.Text;

namespace Codereview4_Csharp.Cornel
{
    class Class1
    {

        string name = null;
        string pizza = null;
        string pizzaSize = null;
        string homeAddress = null;
        string telefonNumber = null;



        public void method2( name)
        {
            Console.WriteLine($"Hi {name} how are you today");
            Console.WriteLine("1:busy but ok;)\n2:never been better :D\n3:pretty good thanks");
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
            Console.WriteLine("Great!would you like to use our express-delivery service?\n1:sounds good\n2:no hurry");
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
            Console.WriteLine("would you like to order some food?\n1:for:not yet,just wanted to chat\n2:yes please");
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
            Console.WriteLine("What type of pizza would you like?\n1:Pizza romana\n2:Pizza diavola\n3:Pizza tonna\n4:Pizza formaggio\n5:Pizza margherita");
            string answer4 = Console.ReadLine();

            switch(answer4)
            {
                case "1":
                    pizza = "Pizza romana";
                        break;

                case "2":
                     pizza = "Pizza diavola";
                    break;

                case "3":
                    pizza = "Pizza tonna";
                    break;

                case "4":
                    pizza = "Pizza formaggio";
                    break;

                case "5":
                    pizza = "Pizza margherita";
                    break;
            }
            
            Console.WriteLine("what size?\n1:small\n2:big\n3:super-big family pizza");
            string answer5 = Console.ReadLine();

            switch (answer5)
            {
                case "1":
                    pizzaSize = "small";
                    break;

                case "2":
                    pizzaSize = "big";
                    break;

                case "3":
                    pizzaSize = "super-big family pizza";
                    break;
            }


            Console.WriteLine("Would you like to add some drinks to your order?\n1:yes please\n2:no,thanks");
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
            Console.WriteLine("1:Bear\n2:Cola\n3:Juice");
            method7();
        }
        public void method7()
        {
            Console.WriteLine("at what time should it be delivered?\n1:asap,i am very hungry\n2:in 1 hour\n2:in 2 hours");
            method8();
        }

        public void method8()
        {
            Console.WriteLine("what payment method do you prefer?\n1:cash\n2:credit card\n3:PayPal\n4:Bitcoin");
            method9();
        }
        public void method9()
        {
            Console.WriteLine("Please enter your address");
            string homeAddress = Console.ReadLine();
            Console.WriteLine("Please enter your tel number");
            string telefonNumber = Console.ReadLine();
            method10();
        }
        public void method10()
        {
            Console.WriteLine("Thankyou for your order");
        }
    }
}
   
