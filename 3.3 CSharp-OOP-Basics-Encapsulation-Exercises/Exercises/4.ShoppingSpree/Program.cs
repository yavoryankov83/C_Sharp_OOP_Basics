using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Person> personList;
    static List<Product> productList;

    static void Main(string[] args)
    {
        personList = new List<Person>();
        productList = new List<Product>();

        var nameAndMoney = Console.ReadLine()
            .Split(';', StringSplitOptions.RemoveEmptyEntries);

        var productAndCost = Console.ReadLine()
            .Split(';', StringSplitOptions.RemoveEmptyEntries);

        try
        {
            foreach (var pair in nameAndMoney)
            {
                var inputPair = pair
                    .Split('=', StringSplitOptions.RemoveEmptyEntries);

                var person = new Person(inputPair[0], decimal.Parse(inputPair[1]));
                personList.Add(person);
            }

            foreach (var pair in productAndCost)
            {
                var inputPair = pair
                   .Split('=', StringSplitOptions.RemoveEmptyEntries);

                var product = new Product(inputPair[0], decimal.Parse(inputPair[1]));
                productList.Add(product);
            }
           
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var pair = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var currPersonName = pair[0];
                var currProductName = pair[1];

                var currPerson = personList.FirstOrDefault(p => p.Name == currPersonName);
                var currProduct = productList.FirstOrDefault(p => p.Name == currProductName);

                var result = currPerson.CanBuyProduct(currProduct);
                Console.WriteLine(result);
            }
        }
        catch (ArgumentException ex)
        {

            Console.WriteLine(ex.Message);
        }
            
        foreach (var person in personList)
        {
            Console.WriteLine(person);
        }
    }
}

