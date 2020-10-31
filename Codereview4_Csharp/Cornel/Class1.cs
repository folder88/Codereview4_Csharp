using System;
using System.Collections.Generic;
using System.Text;

namespace Codereview4_Csharp.Cornel
{
    class Class1
    {

        string nameOrder = null;
        string pizza = null;
        string drink = null;
        string paymentMethod = null;
        string pizzaSize = null;
        string deliveryTime = null;
        string homeAddress = null;
        string telefonNumber = null;



        public void method2(string name)
        {
            Console.WriteLine($"Hi {name} how are you today");
            Console.WriteLine("1:Busy but ok;)\n2:Never been better :D\n3:Pretty good thanks");
            string answer2 = Console.ReadLine();
            nameOrder = name;
            

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
            Console.WriteLine("Great!Would you like to use our express-delivery service?\n1:Sounds good\n2:No hurry");
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
            Console.WriteLine("Would you like to order some food?\n1:Not yet,just wanted to chat\n2:Yes please");
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
            Console.WriteLine("What type of pizza would you like?\n1:Pizza romana\n2:Pizza Diavola\n3:Pizza Tonna\n4:Pizza Formaggio\n5:Pizza Margherita");
            string answer4 = Console.ReadLine();

            switch(answer4)
            {
                case "1":
                    pizza = "Pizza Romana";
                        break;

                case "2":
                     pizza = "Pizza Diavola";
                    break;

                case "3":
                    pizza = "Pizza Tonna";
                    break;

                case "4":
                    pizza = "Pizza Formaggio";
                    break;

                case "5":
                    pizza = "Pizza Margherita";
                    break;
            }
            
            Console.WriteLine("What size?\n1:Small\n2:Big\n3:Super-big Family Pizza");
            string answer5 = Console.ReadLine();

            switch (answer5)
            {
                case "1":
                    pizzaSize = "Small";
                    break;

                case "2":
                    pizzaSize = "Big";
                    break;

                case "3":
                    pizzaSize = "Super-big family pizza";
                    break;
            }


            Console.WriteLine("Would you like to add some drinks to your order?\n1:Yes please\n2:No,thanks");
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
            Console.WriteLine("What drink do you want?\n1:Bear\n2:Cola\n3:Juice");

            string answer7 = Console.ReadLine();
            switch (answer7)
            {
                case "1":
                    drink = "Bear";
                    break;

                case "2":
                    drink = "Cola";
                    break;

                case "3":
                    drink = "Juice";
                    break;
            }

            method7();
        }
        public void method7()
        {
            Console.WriteLine("at what time should it be delivered?\n1:Asap,i am very hungry\n2:In 1 hour\n3:In 2 hours");
            string answer8 = Console.ReadLine();
            switch (answer8)
            {
                case "1":
                    deliveryTime = "Fast as possible";
                    break;

                case "2":
                    deliveryTime = "1 hour";
                    break;

                case "3":
                    deliveryTime = "2 hour";
                    break;
            }
                    method8();
        }

        public void method8()
        {
            Console.WriteLine("What payment method do you prefer?\n1:Cash\n2:Credit card\n3:PayPal\n4:Bitcoin");
            string answer9 = Console.ReadLine();
            switch (answer9)
            {
                case "1":
                    paymentMethod = "Cash";
                    break;

                case "2":
                    paymentMethod = "Credit card";
                    break;

                case "3":
                    paymentMethod = "Paypal";
                    break;

                case "4":
                    paymentMethod = "Bitcoin";
                    break;
            }
            method9();
        }
        public void method9()
        {
            Console.WriteLine("Please enter your address");
            string homeAddressanswer = Console.ReadLine();
            homeAddress = homeAddressanswer;
            Console.WriteLine("Please enter your tel number");
            string telefonNumberanswer = Console.ReadLine();
            telefonNumber = telefonNumberanswer;
            method10();
        }
        public void method10()
        {
            Console.WriteLine("");
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine($"Hi {nameOrder},we are glad to show you the details of your order:\n{pizza} {pizzaSize},{drink} to be delivered at {homeAddress}\nDeliverytime: {deliveryTime}\nYour Paymend method is {paymentMethod}\nWe will send you a SMS to the phone number {telefonNumber} 5 min prior to arrival.\nGrazie mille!!");
            Console.WriteLine("_________________________________________________________________________________________");
        }
    }
}
   
