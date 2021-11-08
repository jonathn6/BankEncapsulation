using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BankEncapsulation!");

            //create a new instance of the BankAccount class.  Allow the user of the application to Deposit money
            //and retrieve their balance through the console.

            var account = new BankAccount(0);

            string userRequest = "";

            do
            {
                Console.WriteLine();
                Console.Write("Enter 'D' to deposit, 'G' to get your balance, or 'X' to exit");
                userRequest = Console.ReadLine();

                userRequest = userRequest.ToUpper();
                double userAmt = 0;
                string userInput = "";
                
                switch (userRequest)
                {
                    case "D":
                        Console.Write("How much would you like to deposit? ");
                        userInput = Console.ReadLine();
                        if (double.TryParse(userInput, out userAmt) == true)
                        {
                            account.Deposit(userAmt);
                        } else
                        {
                            Console.WriteLine("Sorry, but that is not a valid dollar amount.  Please try again.");
                        }
                        break;
                    case "G":
                        Console.WriteLine($"Your account balance is {account.GetBalance()} ");
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("Sorry, but that input is not valid. Please try again.");
                        break;

                }

            } while (userRequest != "X");

        }
    }
}
