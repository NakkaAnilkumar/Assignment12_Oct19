using Assignment13;
using System;
using System.Collections.Generic;
using System.Linq;

public enum UserCategory { Silver, Gold, Platinum }

public class AdminUser
{
    public string Username { get; set; }
    public string Password { get; set; }

    public AdminUser(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public void AddMovie(List<Movie> movies, Movie movie)
    {
        movies.Add(movie);
    }

    public void UpdateMovie(List<Movie> movies, Movie movie)
    {
        // Logic to update movie details
    }

    public void DeleteMovie(List<Movie> movies, Movie movie)
    {
        movies.Remove(movie);
    }
}

public class Movie
{
    public string Title { get; set; }
    public string Language { get; set; }
    public string Genre { get; set; }
    public int InitialStock { get; set; }
    public int AvailableStock { get; set; }

    public Movie(string title, string language, string genre, int initialStock)
    {
        Title = title;
        Language = language;
        Genre = genre;
        InitialStock = initialStock;
        AvailableStock = initialStock;
    }
   
}

public class Program
{
    public static void Main()
    {
        List<Movie> movies = new List<Movie>();

        AdminUser adminUser = new AdminUser("Anilkumar", "123");

        Console.WriteLine("Enter admin username: ");
        string adminUsername = Console.ReadLine();

        Console.WriteLine("Enter admin password: ");
        string adminPassword = Console.ReadLine();

        if (adminUsername == adminUser.Username && adminPassword == adminUser.Password)
        {
            Console.WriteLine("Admin logged in successfully.");

            while (true)
            {
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Update Movie");
                Console.WriteLine("3. Delete Movie");
                Console.WriteLine("4. Show Movies");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter movie title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter language: ");
                        string language = Console.ReadLine();
                        Console.WriteLine("Enter genre: ");
                        string genre = Console.ReadLine();
                        Console.WriteLine("Enter initial stock: ");
                        int initialStock = int.Parse(Console.ReadLine());

                        Movie movie = new Movie(title, language, genre, initialStock);
                        adminUser.AddMovie(movies, movie);
                        Console.WriteLine("Movie added successfully.");
                        break;
                    case 2:
                        // Logic to update movie
                        break;
                    case 3:
                        // Logic to delete movie
                        break;
                    case 4:
                        Console.WriteLine("Movies Added:");
                        foreach (var addedMovie in movies)
                        {
                            Console.WriteLine($"Title: {addedMovie.Title}, Language: {addedMovie.Language}, Genre: {addedMovie.Genre}, Stock: {addedMovie.AvailableStock}");
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Admin login failed. Exiting.");
        }
    }
}