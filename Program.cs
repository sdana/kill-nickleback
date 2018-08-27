using System;
using System.Collections.Generic;

namespace nickleback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string name, string song)> goodSongs = new List<(string name, string song)>();
            HashSet<(string name, string song)> allSongs = new HashSet<(string, string)>(){
                {("The Band", "The Weight")},
                {("Led Zeppelin", "Black Dog")},
                {("Nickleback", "Burn It To The Ground")},
                {("Nickleback", "Feelin' Way Too Damn Good")},
                {("Nickleback", "Rockstar")},
                {("Grateful Dead", "Truckin'")},
                {("Tom Petty", "Wildflowers")},
            };

            foreach ((string name, string song) song in allSongs)
            {
                if (song.name != "Nickleback")
                {
                    goodSongs.Add((song.name, song.song));
                }
            }

            foreach ((string name, string song) song in goodSongs)
            {
                System.Console.WriteLine($"{song.name} sings {song.song} and it's good!");
            }
            
        }
    }
}
