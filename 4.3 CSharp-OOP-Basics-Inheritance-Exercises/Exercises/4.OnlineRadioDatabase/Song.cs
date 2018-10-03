using System;
using System.Collections.Generic;
using System.Text;


public class Song
{
    private string artistName;
    private string songName;
    private int songMinutes;
    private int songSeconds;

    public Song(string artistName, string songName, int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.SongMinutes = minutes;
        this.SongSeconds = seconds;
    }

    public int SongSeconds
    {
        get { return songSeconds; }
        private set
        {
            if (!Validator.IsValidSeconds(value))
            {
                throw new InvalidSongSecondsException(Validator.SECONDS_MIN_LENGTH, Validator.SECONDS_MAX_LENGTH);
            }
            songSeconds = value;
        }
    }


    public int SongMinutes
    {
        get { return songMinutes; }
        private set
        {
            if (!Validator.IsValidMinutes(value))
            {
                throw new InvalidSongMinutesException(Validator.MINUTES_MIN_LENGTH, Validator.MINUTES_MAX_LENGTH);
            }
            songMinutes = value;
        }
    }


    public string SongName
    {
        get { return songName; }
        private set
        {
            if (!Validator.IsValidSongName(value))
            {
                throw new InvalidSongNameException(Validator.SONGNAME_MIN_LENGTH, Validator.SONGNAME_MAX_LENGTH);
            }
            songName = value;
        }
    }


    private string ArtistName
    {
        get { return artistName; }
        set
        {
            if (!Validator.IsValidArtistName(value))
            {
                throw new InvalidArtistNameException(Validator.ARTISTNAME_MIN_LENGTH, Validator.ARTISTNAME_MAX_LENGTH);
            }
            artistName = value;
        }
    }
}

