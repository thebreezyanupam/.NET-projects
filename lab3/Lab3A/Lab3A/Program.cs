/**
 * Name: Anupam Pandey
 * Student Number: 000921043
 * Date: 3rd Nov 2024
 * Purpose: This file contains the entry point of the program, responsible for running the Lab3A class functionality.
 * Statement of Authorship: I, Anupam Pandey, 000921043 certify that this material is my 
 * original work. No other person's work has 
 * been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Represents the main functionality for handling media data and displaying a menu for user interaction.
/// </summary>
public class Lab3A
{
    private List<Media> mediaCollection = new List<Media>(); // Collection to store media objects

    /// <summary>
    /// Reads media data from a file and stores it in a collection.
    /// </summary>
    /// <param name="filePath">The path to the data file.</param>
    public void ReadData(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            int i = 0;

            while (i < lines.Length)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrWhiteSpace(line))
                {
                    i++;
                    continue;
                }

                string[] parts = line.Split('|');
                if (parts.Length < 4)
                {
                    i++;
                    continue;
                }

                string type = parts[0].ToUpper();
                string title = parts[1];
                int year = int.Parse(parts[2]);
                string authorOrDirector = parts[3];
                string summary = "";

                // Read until separator line (-----) or end of file
                i++;
                while (i < lines.Length && !lines[i].Trim().Equals("-----"))
                {
                    summary += lines[i] + " ";
                    i++;
                }

                // Add the media object based on type
                switch (type)
                {
                    case "BOOK":
                        mediaCollection.Add(new Book(title, year, authorOrDirector, summary.Trim()));
                        break;
                    case "MOVIE":
                        mediaCollection.Add(new Movie(title, year, authorOrDirector, summary.Trim()));
                        break;
                    case "SONG":
                        if (parts.Length >= 5)
                        {
                            mediaCollection.Add(new Song(title, year, authorOrDirector, parts[4]));
                        }
                        break;
                }

                // Move to the next line after separator
                i++;
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Data format error: {ex.Message}");
        }
    }


    /// <summary>
    /// Displays a menu for user interaction and handles user input.
    /// </summary>
    public void DisplayMenu()
    {
        int choice;
        do
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Anupam's Media Collection\n=======================");
            Console.ResetColor();
            Console.WriteLine("1. List All Books");
            Console.WriteLine("2. List All Movies");
            Console.WriteLine("3. List All Songs");
            Console.WriteLine("4. List All Media");
            Console.WriteLine("5. Search All Media by Title");
            Console.WriteLine("6. Exit Program");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ListMedia(typeof(Book));
                        break;
                    case 2:
                        ListMedia(typeof(Movie));
                        break;
                    case 3:
                        ListMedia(typeof(Song));
                        break;
                    case 4:
                        ListAllMedia();
                        break;
                    case 5:
                        SearchMediaByTitle();
                        break;
                    case 6:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        } while (choice != 6);
    }

    /// <summary>
    /// Lists all media objects stored in the collection.
    /// </summary>
    private void ListAllMedia()
    {
        Console.WriteLine("\nListing all media:");
        foreach (var media in mediaCollection)
        {
            if (media != null)
            {
                if (media is Book book)
                {
                    Console.WriteLine($"Book Title: {book.Title} ({book.Year})");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"\n{book.Decrypt()}");
                }
                else if (media is Movie movie)
                {
                    Console.WriteLine($"Movie Title: {movie.Title} ({movie.Year})");
                    Console.WriteLine($"Director: {movie.Director}");
                    Console.WriteLine($"\n{movie.Decrypt()}");
                }
                else if (media is Song song)
                {
                    Console.WriteLine($"Song Title: {song.Title} ({song.Year})");
                    Console.WriteLine($"Album: {song.Album}  Artist: {song.Artist}");
                }
                Console.WriteLine("--------------------");
            }
        }
    }

    private void ListMedia(Type mediaType)
    {
        Console.WriteLine($"\nListing all {mediaType.Name}s:");
        foreach (var media in mediaCollection)
        {
            if (media != null && media.GetType() == mediaType)
            {
                if (media is Book book)
                {
                    Console.WriteLine($"Book Title: {book.Title} ({book.Year})");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Summary: {book.Decrypt()}"); // Display decrypted summary
                }
                else if (media is Movie movie)
                {
                    Console.WriteLine($"Movie Title: {movie.Title} ({movie.Year})");
                    Console.WriteLine($"Director: {movie.Director}");
                    Console.WriteLine($"Description: {movie.Decrypt()}"); // Display decrypted description
                }
                else if (media is Song song)
                {
                    Console.WriteLine($"Song Title: {song.Title} ({song.Year})");
                    Console.WriteLine($"Album: {song.Album}  Artist: {song.Artist}");
                }
                Console.WriteLine("--------------------");
            }
        }
    }

    private void SearchMediaByTitle()
    {
        Console.Write("Enter a search string: ");
        string key = Console.ReadLine().ToLower();

        Console.WriteLine("\nSearch Results:");
        foreach (var media in mediaCollection)
        {
            if (media != null && media.Search(key))
            {
                if (media is Book book)
                {
                    Console.WriteLine($"Book Title: {book.Title} ({book.Year})");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Summary: {book.Decrypt()}"); // Display decrypted summary
                }
                else if (media is Movie movie)
                {
                    Console.WriteLine($"Movie Title: {movie.Title} ({movie.Year})");
                    Console.WriteLine($"Director: {movie.Director}");
                    Console.WriteLine($"Description: {movie.Decrypt()}"); // Display decrypted description
                }
                else if (media is Song song)
                {
                    Console.WriteLine($"Song Title: {song.Title} ({song.Year})");
                    Console.WriteLine($"Album: {song.Album}  Artist: {song.Artist}");
                }
                Console.WriteLine("--------------------");
            }
        }
    }

}

/// <summary>
/// Entry point for the program.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Lab3A app = new Lab3A();
            app.ReadData("..\\..\\Data.txt"); // Reading the data.txt file
            app.DisplayMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
