using System;
using System.Collections.Generic;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    protected virtual decimal Price
    {
        get { return this.price; }
        set
        {
            Validator.IsPriceValid(value);
            this.price = value;
        }
    }


    private string Author
    {
        get { return this.author; }
        set
        {
            Validator.IsValidAuthor(value);
            this.author = value;
        }
    }


    private string Title
    {
        get { return this.title; }
        set
        {
            Validator.IsTitleValid(value);
            this.title = value;
        }
    }

    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");

        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }
}

