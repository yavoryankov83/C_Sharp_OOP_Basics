using System;


class Program
{
    static void Main(string[] args)
    {
        var smartPhone = new Smartphone("Smartphone");
        GetPhone(smartPhone);
    }

    private static void GetPhone(Smartphone smartPhone)
    {
        var inputPhoneNumbers = Console.ReadLine()
           .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var phoneNumber in inputPhoneNumbers)
        {
            Console.WriteLine(smartPhone.Calling(phoneNumber));
        }

        var inputSites = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var web in inputSites)
        {
            Console.WriteLine(smartPhone.Browsing(web));
        }
    }
}

