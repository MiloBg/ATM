using System;

namespace ATM
{
    public class Account
    {
        // Props
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        private decimal Balance { get; set; }
        public Person Owner { get; set; }
        // Constructor
        public Account(string accountNumber, string pinCode, Person owner)
        {
            AccountNumber = accountNumber;
            PinCode = pinCode;
            Balance = 0;
            Owner = owner;
        }
        // Methods
        public void OwnerChange(Person no) {
            Owner = no;
        }
        public decimal Payment(decimal ammount) {
            Balance += ammount;
            return Balance;
        }
        public decimal Payout(decimal ammount) {
            Balance -= ammount;
            return Balance;
        }
        public void Description() {
            System.Console.WriteLine($"Account number {AccountNumber} is owned by {Owner.FullName}, {Owner.UserType}. Current balance: {Balance}.");
        }
        public void AccountBalanceCheck() {
            System.Console.WriteLine($"Account {AccountNumber} current balance: {Balance}. Chcecked on {DateTime.Now}.");
        }
    }
}