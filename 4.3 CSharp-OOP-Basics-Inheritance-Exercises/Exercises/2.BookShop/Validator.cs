using System;
using System.Collections.Generic;
using System.Text;


public static class Validator
{
    private const int MIN_TITLE_LENGTH = 3;
    private const decimal MIN_PRICE = 1;

    public static bool IsValidAuthor(string author)
    {   
        var authorName = author.Split();

        var validSecondName = authorName.Length == 2 && !(char.IsDigit(authorName[1][0]));

        if (!validSecondName)
        {
            throw new ArgumentException("Author not valid!");
        }

        return true;
    }

    public static bool IsTitleValid(string title)
    {
        var titleNameLength = title.Length;

        if (titleNameLength < MIN_TITLE_LENGTH)
        {
            throw new ArgumentException("Title not valid!");
        }

        return true;
    }

    public static bool IsPriceValid(decimal price)
    {
        if (price < MIN_PRICE)
        {
            throw new ArgumentException("Price not valid!");
        }

        return true;
    }
}

