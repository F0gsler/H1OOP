namespace IndkapslingC
{
    internal class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Owner(int Id, string firstName, string lastName)
        {
            // Hardcoded values as specified
            this.Id = 123456;
            FirstName = "Marius";
            LastName = "Fogelgren";
        }

        // Property to get the full name
        public string FullName => $"{FirstName} {LastName}";
    }

    internal class Account
    {
        public double Balance { get; private set; }
        public int Id { get; private set; }
        public Owner AccountOwner { get; set; }

        public Account(double balance, int id, Owner owner)
        {
            // Hardcoded values as specified
            Balance = 100;
            Id = 123456;
            AccountOwner = owner;
        }

        // Deposit method that adds to the balance and returns the update message
        public string Deposit(double amount)
        {
            Balance += amount;
            return UpdateMessage();
        }

        // Withdraw method that subtracts from the balance and returns the update message
        public string Withdraw(double amount)
        {
            Balance -= amount;
            return UpdateMessage();
        }

        // method to generate the update message
        private string UpdateMessage()
        {
            return $"Your account is updatet.Your saldo is {Balance:F2}";
        }
    }
}
