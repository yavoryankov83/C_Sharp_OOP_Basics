using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DefineBankAccountClass
    {
        static void Main(string[] args)
        {
        var accounts = new Dictionary<int, BankAccount>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var command = input.Split();
            var currComand = command[0];

            switch (currComand)
            {
                case "Create": 
                    Create(command, accounts);
                    break;
                case
                    "Deposit":
                    Deposit(command, accounts);
                    break;
                case
                    "Withdraw":
                    Withdraw(command, accounts);
                    break;
                case
                    "Print":
                    Print(command, accounts);
                    break;
            }
        }

        }

    private static void Print(string[] command, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(command[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdraw(string[] command, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(command[1]);
        var amount = double.Parse(command[2]);

        if (accounts.ContainsKey(id))
        {
            if (accounts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Withdraw(amount);
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Deposit(string[] command, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(command[1]);
        var amount = double.Parse(command[2]);

        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Create(string[] command, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(command[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id, acc);
        }
    }
}

