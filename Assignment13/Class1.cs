using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    using System;
    using System.Collections.Generic;

    // Enums
    public enum UserCategory { Silver, Gold, Platinum }

    // User class
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserCategory Category { get; set; }
        public List<Rental> Rentals { get; set; }

        public User(string username, string password, UserCategory category)
        {
            Username = username;
            Password = password;
            Category = category;
            Rentals = new List<Rental>();
        }

        public bool Login(string password)
        {
            return Password == password;
        }

        public void SearchMovies(string language, string genre)
        {
            // Logic to search and display movies based on language and genre
        }

        public bool RentMovie(Movie movie, int days)
        {
            // Logic to handle movie rental
            // Check user category and rental limit
            // Update available stock, add to Rentals list, and calculate cost
            return true; // Return true if rental was successful
        }

        public bool ReturnMovie(Movie movie)
        {
            // Logic to handle movie return
            // Update available stock and calculate cost
            return true; // Return true if return was successful
        }

        public bool CancelRental(Rental rental)
        {
            // Logic to cancel a rental if not delivered
            // Remove rental from Rentals list and update stock
            return true; // Return true if cancellation was successful
        }
    }

    // Movie class
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

    // Rental class
    public class Rental
    {
        public Movie Movie { get; set; }
        public DateTime RentalDate { get; set; }
        public int DaysRented
        {
            get; set;
        }
        public decimal Cost { get; set; }
    }

    // Main program (for testing purposes)
    public class Program
    {
        public static void Mai()
        {
            // Create user, movies, and test the functionality
            // Example: User login, search movies, rent a movie, return a movie, cancel a rental, etc.
        }
    }
}