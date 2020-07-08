using System;
using System.Runtime.CompilerServices;

namespace BankEncapsulationconsol
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalInformation info = new PersonalInformation();

            Console.WriteLine("Please enter your phone number!");

            info.FormattedNumber = Console.ReadLine();

            Console.WriteLine($"This is your number correctly formatted!{info}"); BankAccount ba = new BankAccount();
            Console.WriteLine("Please give me money");
            double amount = double.Parse(Console.ReadLine());

            ba.SetBalance(amount);


            Console.WriteLine($"You currently have{ba.GetBalance(),0:c}in your bank account");


            Console.WriteLine($"This is your number correctly formatted!{info}"); Savings sa = new Savings();
            Console.WriteLine("Please give me money");
            double savingamount = double.Parse(Console.ReadLine());

            sa.SetBalance(amount);


            Console.WriteLine($"You currently have{sa.GetBalance(),0:c}in your savings account");


            Console.WriteLine($"This is your credit card number correctly formatted!{info}"); CreditCard cr = new CreditCard();
            Console.WriteLine("Please increase my balance");
            double creditcardamount = double.Parse(Console.ReadLine());

            cr.SetBalance(amount);


            Console.WriteLine($"You currently have{cr.GetBalance(),0:c}on your credit card balance");


            

            


        }


    }


}
