using System.Security.Cryptography.X509Certificates;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBankAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            double depositAmount = double.Parse(Console.ReadLine());
            myBankAccount.Deposit(depositAmount);
            
            Console.WriteLine($"Thank you your balance is now ${myBankAccount.GetBalance()}");
        }
    } 
}
