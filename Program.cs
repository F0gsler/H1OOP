using IndkapslingC;

namespace OOPOpgave2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Owner owner = new Owner(123456, "Marius", "Fogelgren");

            Account account = new Account(100, 123456, owner);
            Console.WriteLine($"Hej {owner.FullName}, din konto er oprettet.");
            
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            string depositMessage = account.Deposit(depositAmount);
            Console.WriteLine(depositMessage);

            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            string withdrawMessage = account.Withdraw(withdrawAmount);
            Console.WriteLine(withdrawMessage);
    
        }
    }
}
