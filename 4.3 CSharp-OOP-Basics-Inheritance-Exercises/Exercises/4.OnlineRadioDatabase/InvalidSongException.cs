using System;
using System.Collections.Generic;
using System.Text;


public class InvalidSongException:Exception
{
    private const string MESSAGE = "Invalid song.";

    public InvalidSongException()
        :base(MESSAGE)
    {

    }

    public InvalidSongException(string message)
        :base(message)
    {

    }
}

