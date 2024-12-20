using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// Initialize the secret message as a list of strings
		List<string> secretMessage = new List<string>
		{
			"Learning", "is", "not", "about", "what", "you", "get", "easily", "the",
			"first", "time,", "it", "is", "about", "what", "you", "can", "figure",
			"out.", "-2015,", "Chris", "Pine,", "Learn", "JavaScript"
		};

		// Remove the last item ("JavaScript")
		secretMessage.RemoveAt(secretMessage.Count - 1);

		// Add new words to the end of the list
		secretMessage.Add("to");
		secretMessage.Add("Program");

		// Replace the 8th word ("easily") with "right"
		secretMessage[7] = "right";

		// Remove the first item ("Learning")
		secretMessage.RemoveAt(0);

		// Add a new word at the beginning of the list
		secretMessage.Insert(0, "Programming");

		// Replace a segment of the list (starting at index 6) with a single word ("know,")
		secretMessage.RemoveRange(6, 5);
		secretMessage.Insert(6, "know,");

		// Join the list into a single string and display the secret message
		Console.WriteLine(string.Join(" ", secretMessage));
	}
}