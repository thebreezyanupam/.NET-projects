/**
 * Name: Anupam Pandey
 * Student Number: 000921043
 * Date: 3rd Nov 2024
 * Purpose: This file defines the Song class, which represents a song with properties for album and artist.
 * Statement of Authorship: I, Anupam Pandey, 000921043 certify that this material is my 
 * original work. No other person's work has 
 * been used without due acknowledgement.
 */

using System;

/// <summary>
/// Represents a song with properties for the album and artist.
/// </summary>
public class Song : Media
{
    /// <summary>
    /// Gets the album of the song.
    /// </summary>
    public string Album { get; private set; }

    /// <summary>
    /// Gets the artist of the song.
    /// </summary>
    public string Artist { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Song"/> class.
    /// </summary>
    /// <param name="title">The title of the song.</param>
    /// <param name="year">The release year of the song.</param>
    /// <param name="album">The album the song belongs to.</param>
    /// <param name="artist">The artist who performed the song.</param>
    public Song(string title, int year, string album, string artist) : base(title, year)
    {
        Album = album;
        Artist = artist;
    }

    /// <summary>
    /// Returns a string representation of the song.
    /// </summary>
    /// <returns>A formatted string with song details.</returns>
    public override string ToString() => $"Song: {Title} by {Artist} from album '{Album}' ({Year})";
}
