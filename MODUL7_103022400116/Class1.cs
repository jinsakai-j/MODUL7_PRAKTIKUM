using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MODUL7_103022400116
{
    internal class FilmFavorit_103022400035
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public Boolean isWatched { get; set; }

        public void ReadJSON()
        {
            string filePath = "jurnal7_1_103022400035.json";
            string jsonString = File.ReadAllText(filePath);

            FilmFavorit_103022400035 film = JsonSerializer.Deserialize<FilmFavorit_103022400035>(jsonString);
            Console.WriteLine("title: " + film.title);
            Console.WriteLine("director: " + film.director);
            Console.WriteLine("year: " + film.year);
            Console.WriteLine("genre: " + film.genre);
            Console.WriteLine("rating: " + film.rating);
            Console.WriteLine("duration: " + film.durationMinutes);
            Console.WriteLine("watched: " + film.isWatched);
        }
    }
}
