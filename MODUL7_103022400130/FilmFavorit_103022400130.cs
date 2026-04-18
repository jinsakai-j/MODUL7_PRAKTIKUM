using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7_103022400116
{
    internal class FilmFavorit_103022400130
    {
        public string title {  get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public Boolean isWatched { get; set; }

        public void ReadJSON()
        {
            try
            {
                string filePath = "jurnal7_1_103022400130.json";
                string jsonString = File.ReadAllText(filePath);

                FilmFavorit_103022400130 film = JsonSerializer.Deserialize<FilmFavorit_103022400130>(jsonString);

                Console.WriteLine("Watchlist Name : " + film.title);
                Console.WriteLine("Creaetd By : " + film.director);
                Console.WriteLine("Year : " + film.year);
                Console.WriteLine("Genre : " + film.genre);
                Console.WriteLine("Rating : " + film.rating);
                Console.WriteLine("Durasi : " + film.durationMinutes);
                Console.WriteLine("Is Watched : " + film.isWatched);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saat membaca JSON: {ex.Message}");
            }
        }
    }
}
