using System;
using System.Collections.Generic;
using System.Text;


public static class Validator
{
    public const int ARTISTNAME_MIN_LENGTH = 3;
    public const int ARTISTNAME_MAX_LENGTH = 20;

    public const int SONGNAME_MIN_LENGTH = 3;
    public const int SONGNAME_MAX_LENGTH = 30;

    public const int MINUTES_MIN_LENGTH = 0;
    public const int MINUTES_MAX_LENGTH = 14;

    public const int SECONDS_MIN_LENGTH = 0;
    public const int SECONDS_MAX_LENGTH = 59;

    public static bool IsValidArtistName(string artistName)
    {
        return artistName.Length > ARTISTNAME_MIN_LENGTH
            && artistName.Length < ARTISTNAME_MAX_LENGTH;
    }

    public static bool IsValidSongName(string songName)
    {
        return songName.Length > SONGNAME_MIN_LENGTH
            && songName.Length < SONGNAME_MAX_LENGTH;
    }

    public static bool IsValidMinutes(int minutes)
    {
        return minutes >= MINUTES_MIN_LENGTH &&
            minutes <= MINUTES_MAX_LENGTH;
    }

    public static bool IsValidSeconds(int seconds)
    {
        return seconds >= SECONDS_MIN_LENGTH &&
            seconds <= SECONDS_MAX_LENGTH;
    }
}

