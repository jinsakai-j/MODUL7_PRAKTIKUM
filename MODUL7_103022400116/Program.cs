using System;
using System.IO;
using System.Text.Json;

internal class Program
{
    static void Main(string[] args) {
        FilmFavorit_103022400116 filmFavorit = new FilmFavorit_103022400116();
        filmFavorit.ReadJSON();
        
        Console.WriteLine();
        FilmFavorit_103022400035 films = new FilmFavorit_103022400035();
        films.ReadJSON();
    }
}
