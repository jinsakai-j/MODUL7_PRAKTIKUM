using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text;
public class FilmFavorit_103022400116
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
        try
        {
            string filePath = "jurnal7_1_103022400116.json";
            string jsonString = File.ReadAllText(filePath);

            FilmFavorit_103022400116 film = JsonSerializer.Deserialize<FilmFavorit_103022400116>(jsonString);
            Console.WriteLine("Watchlist Name: " + film.title);
            Console.WriteLine("Created By: " + film.director);
            Console.WriteLine("Year: " + film.year);
            Console.WriteLine("Genre: " + film.genre);
            Console.WriteLine("Rating: " + film.rating);
            Console.WriteLine("Duration (minutes): " + film.durationMinutes);
            Console.WriteLine("Watched: " + film.isWatched);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Eror saat membaca JSON file: " + ex.Message);
        }
    }
}
