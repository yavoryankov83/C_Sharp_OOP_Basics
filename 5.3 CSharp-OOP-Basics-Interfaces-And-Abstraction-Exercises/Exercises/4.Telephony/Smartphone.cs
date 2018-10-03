using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Smartphone : IPhone
{
    public string Model { get; private set; }

    public Smartphone(string model)
    {
        this.Model = model;
    }

    public string Browsing(string webSite)
    {
        if (this.IsWebSiteInvalid(webSite))
        {
            return "Invalid URL!";
        }
        else
        {
            return $"Browsing: {webSite}!";
        }
    }

    public string Calling(string phoneNumber)
    {
        if (this.IsPhoneNumberInvalid(phoneNumber))
        {
            return "Invalid number!";
        }
        else
        {
            return $"Calling... {phoneNumber}";
        }
    }

    private bool IsWebSiteInvalid(string webSite)
    {
        return webSite.Any(c => char.IsDigit(c));
    }

    private bool IsPhoneNumberInvalid(string phoneNumber)
    {
        return phoneNumber.Any(d => !(char.IsDigit(d)));
    }
}

