namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bill", "Gates", Type.LegalEntity);
            Person p2 = new Person("Elon", "Musk", Type.Individual);

            Account a1 = new Account("28101955", "1111", p1);
            Account a2 = new Account("28061971", "2222", p2);

            System.Console.WriteLine("Enter PIN:");
            string pin = Console.ReadLine();
                if (pin == a1.PinCode)
                {
                    a1.Description();
                    System.Console.WriteLine("Please choose an option:\nOption 1 - Payout\nOption 2 - Payment\nOption 3 - Account Balance Check");
                    string entry = Console.ReadLine();
                    if (entry == "1")
                    {
                        System.Console.WriteLine("How much would you like to payout:");
                        decimal ammount = decimal.Parse(Console.ReadLine());
                        a1.Payout(ammount);
                        a1.AccountBalanceCheck();
                    } else if (entry == "2")
                    {
                        System.Console.WriteLine("How much would you like to commit to this account:");
                        decimal ammount = decimal.Parse(Console.ReadLine());
                        a1.Payment(ammount);
                        a1.AccountBalanceCheck();
                    } else if (entry == "3")
                    {
                        a1.AccountBalanceCheck();
                    }
                }

            if (pin == a2.PinCode)
                    {
                    a2.Description();
                    System.Console.WriteLine("Please choose an option:\nOption 1 - Payout\nOption 2 - Payment\nOption 3 - Account Balance Check");
                    string entry = Console.ReadLine();
                    if (entry == "1")
                    {
                        System.Console.WriteLine("How much would you like to payout:");
                        decimal ammount = decimal.Parse(Console.ReadLine());
                        a2.Payout(ammount);
                        a2.AccountBalanceCheck();
                    } else if (entry == "2")
                    {
                        System.Console.WriteLine("How much would you like to commit to this account:");
                        decimal ammount = decimal.Parse(Console.ReadLine());
                        a2.Payment(ammount);
                        a2.AccountBalanceCheck();
                    } else if (entry == "3")
                    {
                        a2.AccountBalanceCheck();
                    }
                }
        }
    } 
}