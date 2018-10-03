﻿using System;
using System.Collections.Generic;
using System.Text;


public class InvalidSongMinutesException:InvalidSongLengthException
{
    public InvalidSongMinutesException()
        :base()
    {

    }

    public InvalidSongMinutesException(string message)
        :base(message)
    {

    }

    public InvalidSongMinutesException(int minSongMinutes, int maxSongMinutes)
            : base($"Song minutes should be between {minSongMinutes} and {maxSongMinutes}.")
    {

    }
}

