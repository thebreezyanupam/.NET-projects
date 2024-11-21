
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
///<summary>
///     Name: Anupam Pandey
///     Student ID: 000921043
///     Date: 17th Nov 2024
///     Program Purpose: This program is designed to load an HTML file, validate its tags,
///                      and determine if the HTML tags are balanced. 
///     Statement of Authorship: I, Anupam Pandey, 000921043 certify that this material is my original work.  
///                              No other person's work has been used without due acknowledgement.
///
/// 
/// </summary>

namespace Lab4B
{
    /// <summary>
    /// This is the main form for the Lab4B application.
    /// It allows the user to load an HTML file, check the tags, 
    /// and display the results to check if the tags are balanced.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Stores the content of the loaded HTML file.
        /// </summary>
        private string loadedHtmlContent = string.Empty;

        /// <summary>
        /// Stores the name of the loaded HTML file.
        /// </summary>
        private string fileName;

        /// <summary>
        /// Initializes the form and sets the default message for the label.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            labelOutput.Text = "No file selected"; // Default message
        }

        /// <summary>
        /// Opens a file dialog to load an HTML file and displays the file name in a label.
        /// </summary>
        /// <param name="sender">The button that triggered this event.</param>
        /// <param name="e">Event data.</param>
        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "HTML Files (*.html)|*.html|All Files (*.*)|*.*",
                Title = "Select an HTML file"
                 
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the file content and set the file name
                loadedHtmlContent = File.ReadAllText(openFileDialog.FileName);
                fileName = Path.GetFileName(openFileDialog.FileName);

                // Update the label and clear the list box for new output
                labelOutput.Text = $"File \"{fileName}\" loaded successfully.";
                lb_Output.Items.Clear();
                lb_Output.ClearSelected();
                
            }
            else
            {
                // Show a message if no file is selected
                labelOutput.Text = "No file selected.";
            }
        }

        /// <summary>
        /// Closes the application when the exit button is clicked.
        /// </summary>
        /// <param name="sender">The button that triggered this event.</param>
        /// <param name="e">Event data.</param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Checks if the HTML tags in the loaded file are balanced and displays the result.
        /// </summary>
        /// <param name="sender">The button that triggered this event.</param>
        /// <param name="e">Event data.</param>
        private void checkTags_Click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loadedHtmlContent))
            {
                // Show an error if no file is loaded
                MessageBox.Show("Please load an HTML file before checking tags.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear the list box for fresh results
            lb_Output.Items.Clear();

            // Check if the tags are balanced
            bool areTagsBalanced = CheckTagsBalance(loadedHtmlContent);

            // Update the label with the result
            if (areTagsBalanced)
            {
                labelOutput.Text = fileName + " has balanced tags!";
            }
            else
            {
                labelOutput.Text = fileName + " does not have balanced tags!";
            }
        }

        /// <summary>
        /// Uses a stack to check if the HTML tags in the content are balanced.
        /// </summary>
        /// <param name="htmlContent">The HTML content to check.</param>
        /// <returns>True if the tags are balanced, false otherwise.</returns>
        private bool CheckTagsBalance(string htmlContent)
        {
            Stack<string> tagStack = new Stack<string>(); // Keeps track of opening tags
            Regex tagRegex = new Regex(@"<(/?)(\w+)(.*?)>"); // Regex to find tags
            MatchCollection matches = tagRegex.Matches(htmlContent);

            int indentLevel = 0; // Keeps track of nesting levels for output formatting

            foreach (Match match in matches)
            {
                string tag = match.Groups[2].Value.ToLower(); // Convert tag to lowercase
                bool isClosingTag = match.Groups[1].Value == "/"; // Check if it's a closing tag

                
                if (IsNonContainerTag(tag))
                {
                    lb_Output.Items.Add(new string(' ', indentLevel * 4) + $"Found non-container tag: <{tag}>");
                    continue;
                }

                if (!isClosingTag)
                {
                    tagStack.Push(tag);
                    lb_Output.Items.Add(new string(' ', indentLevel * 4) + $"Found opening tag: <{tag}>");
                    indentLevel++; 
                }
                else
                {
                    // Handle closing tags
                    indentLevel = Math.Max(0, indentLevel - 1); 
                    lb_Output.Items.Add(new string(' ', indentLevel * 4) + $"Found closing tag: </{tag}>");

                    if (tagStack.Count == 0 || tagStack.Peek() != tag)
                    {
                        return false;
                    }

                   
                    tagStack.Pop();
                }
            }

            // Check for unmatched opening tags
            if (tagStack.Count > 0)
            {
                foreach (var unclosedTag in tagStack)
                {
                    lb_Output.Items.Add($"Error: Unmatched opening tag <{unclosedTag}>");
                }
                return false; // Tags are not balanced
            }

            return true; // Tags are balanced
        }

        /// <summary>
        /// Checks if a tag is a self-closing or non-container tag.
        /// </summary>
        /// <param name="tag">The name of the tag to check.</param>
        /// <returns>True if the tag is a non-container tag, false otherwise.</returns>
        private bool IsNonContainerTag(string tag)
        {
            string[] nonContainerTags = { "img", "hr", "br", "input", "meta", "link", "area" };
            return Array.Exists(nonContainerTags, t => t.Equals(tag, StringComparison.OrdinalIgnoreCase));
        }
    }
}
