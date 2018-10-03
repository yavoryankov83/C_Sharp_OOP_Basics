using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        //var acc = new BankAccount();
        //acc.Id = 1;
        //acc.Deposit(15);
        //acc.Withdraw(10);
        //Console.WriteLine(acc);

        var accounts = new Dictionary<int, BankAccount>();

        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            var tokens = command.Split();
            var currCommand = tokens[0];
            var accountId = int.Parse(tokens[1]);

            switch (currCommand)
            {
                case "Create":
                    Create(accountId, accounts);
                    break;
                case "Deposit":
                    var amount = decimal.Parse(tokens[2]);
                    Deposit(accountId, amount, accounts);
                    break;
                case "Withdraw":
                    var amount1 = decimal.Parse(tokens[2]);
                    Withdraw(accountId, amount1, accounts);
                    break;
                case "Print":
                    Print(accountId, accounts);
                    break;
            }
        }
    }

    private static void Print(int accountId, Dictionary<int, BankAccount> accounts)
    {
        if (!IsExist(accountId, accounts))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine($"Account ID{accountId}, balance {accounts[accountId].Balance:F2}");
        }
    }

    private static void Withdraw(int accountId, decimal amount, Dictionary<int, BankAccount> accounts)
    {
        if (!IsExist(accountId, accounts))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            if (accounts[accountId].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[accountId].Withdraw(amount);
            }
        }
    }

    private static void Deposit(int accountId, decimal amount, Dictionary<int, BankAccount> accounts)
    {
        if (!IsExist(accountId, accounts))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[accountId].Deposit(amount);
        }
    }

    private static void Create(int accountId, Dictionary<int, BankAccount> accounts)
    {
        if (!IsExist(accountId, accounts))
        {
            accounts.Add(accountId, new BankAccount());
        }
        else
        {
            Console.WriteLine("Account already exists");
        }
    }
    private static bool IsExist(int accountId, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(accountId))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

