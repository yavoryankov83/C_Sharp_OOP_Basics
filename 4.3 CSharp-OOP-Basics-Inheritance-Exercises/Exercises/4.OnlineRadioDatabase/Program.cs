using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var songs = GetSongs();
        PrintSongs(songs);
    }

    private static void PrintSongs(Stack<Song> songs)
    {
        Console.WriteLine($"Songs added: {songs.Count}");

        var totalSeconds = songs.Select(s => s.SongSeconds).Sum();
        var secondsToMinutes = totalSeconds / 60;
        var seconds = totalSeconds % 60;

        var totalMinutes = songs.Select(s => s.SongMinutes).Sum() + secondsToMinutes;
        var minutesToHours = totalMinutes / 60;
        var minutes = totalMinutes % 60;

        var hours = minutesToHours;

        Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
    }

    private static Stack<Song> GetSongs()
    {
        var songs = new Stack<Song>();

        var songsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < songsCount; i++)
        {
            var currData = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                if (currData.Length < 3)
                {
                    throw new InvalidSongException();
                }

                var artistName = currData[0];
                var songName = currData[1];
                var minAndSec = currData[2]
                    .Split(':',StringSplitOptions.RemoveEmptyEntries);

                var minutes = int.Parse(minAndSec[0]);
                var seconds = int.Parse(minAndSec[1]);

                songs.Push(new Song(artistName, songName, minutes, seconds));
                Console.WriteLine("Song added.");
            }
            catch (InvalidSongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid song length.");
            }
        }

        return songs;
    }
}

