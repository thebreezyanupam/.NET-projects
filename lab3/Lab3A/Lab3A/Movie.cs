/**
 * Name: Anupam Pandey
 * Student Number: 000921043
 * Date: 3rd Nov 2024
 * Purpose: This file defines the Movie class, which represents a movie and implements IEncryptable for encryption and decryption of the description.
 * Statement of Authorship: I, Anupam Pandey, 000921043 certify that this material is my 
 * original work. No other person's work has 
 * been used without due acknowledgement.
 */

using System;

/// <summary>
/// Represents a movie with properties for the director and summary, and provides encryption functionality.
/// </summary>
public class Movie : Media, IEncryptable
{
    /// <summary>
    /// Gets the director of the movie.
    /// </summary>
    public string Director { get; private set; }

    /// <summary>
    /// Gets the summary of the movie, which can be encrypted or decrypted.
    /// </summary>
    public string Summary { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Movie"/> class.
    /// </summary>
    /// <param name="title">The title of the movie.</param>
    /// <param name="year">The release year of the movie.</param>
    /// <param name="director">The director of the movie.</param>
    /// <param name="summary">The summary of the movie.</param>
    public Movie(string title, int year, string director, string summary) : base(title, year)
    {
        Director = director;
        Summary = summary;
    }

    /// <summary>
    /// Encrypts the summary using the Rot13 algorithm.
    /// </summary>
    /// <returns>The encrypted summary.</returns>
    public string Encrypt() => Rot13(Summary);

    /// <summary>
    /// Decrypts the summary using the Rot13 algorithm.
    /// </summary>
    /// <returns>The decrypted summary.</returns>
    public string Decrypt() => Rot13(Summary);

    /// <summary>
    /// Applies the Rot13 algorithm to the input string.
    /// </summary>
    /// <param name="input">The string to be processed with Rot13.</param>
    /// <returns>The processed string after applying Rot13.</returns>
    private string Rot13(string input)
    {
        char[] array = input.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            int number = array[i];

            if (number >= 'a' && number <= 'z')
            {
                number = ((number - 'a' + 13) % 26) + 'a';
            }
            else if (number >= 'A' && number <= 'Z')
            {
                number = ((number - 'A' + 13) % 26) + 'A';
            }

            array[i] = (char)number;
        }
        return new string(array);
    }

    /// <summary>
    /// Returns a string representation of the movie.
    /// </summary>
    /// <returns>A formatted string with movie details.</returns>
    public override string ToString() => $"Movie: {Title} directed by {Director} ({Year})";
}
