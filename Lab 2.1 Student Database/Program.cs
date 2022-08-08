using System.Threading.Tasks;
string[] names = { "John", "Linda", "Kelly", "Fredrik", "Yoshi", "Cortana" };
string[] hometown = { "Los Angeles", "Toronto", "Sydney", "Berlin", "Tokyo", "Cairo" };
string[] favoriteFood = { "Tacos", "Poutine", "Vegemite", "Bratwurst", "Sushi", "Shwarma" };

Console.WriteLine("Welcome to the student database!\n");
Thread.Sleep(1500);

do
{
	bool firstKeepGoing = false;
	while (!firstKeepGoing)
	{
		Console.Write($"Which student would you like to learn about?\nEnter a number 1-6, or to see a directory type 'dir'  ");
		string choiceAsStr = Console.ReadLine();
		if (choiceAsStr == "dir")
		{
			Console.WriteLine();
			for (int index = 0; index < names.Length; index++) //I did it
			{
				Console.WriteLine(names[index]);
			}
			Console.WriteLine();
			continue;


		}
		int choice;
		bool validChoice = int.TryParse(choiceAsStr, out choice);
		choice--;

		if (!validChoice || choice < 0 || choice > 7)
		{
			Console.WriteLine("\nThat is not a valid response.\n\n");
			continue;
		}
		else
		{
			Console.WriteLine($"\nThis student is {names[choice]}");
		}


		bool validAdditional = true;
		while (validAdditional)
		{

			Console.Write($"\nWhat would you like to know about {names[choice]}? Enter 'Hometown' or 'Favorite Food':\t");
			string additional = Console.ReadLine().ToLower();
			if (additional == "hometown" || additional == "home")
			{
				Console.WriteLine($"\n{names[choice]} is from {hometown[choice]}.");
				validAdditional = false;
				firstKeepGoing = true;
			}
			else if (additional == "favorite food" || additional == "food")
			{
				Console.WriteLine($"\n{names[choice]} favorite food is {favoriteFood[choice]}.");
				validAdditional = false;
				firstKeepGoing = true;
			}
			else
			{
				Console.WriteLine("That category does not exist. Please try again. Enter 'Hometown' or 'Favorite Food'");
				continue;
			}

		}
	}
} while (KeepGoing());

static bool KeepGoing()
{
	while (true)
	{
		// Print out message asking if user wants to continue
		Console.Write("\nWould you like to learn about another student? (y/n):\t");
		// Ask the user for their input
		string response = Console.ReadLine();
		response = response.ToLower();
		// Check if they typed "y". If so, return true.
		// Otherwise return false.   YES   yes
		if (response == "y" || response == "yes")
		{
            Console.WriteLine("Great!");
			Thread.Sleep(1500);
			return true;
		}
		else if (response == "n" || response == "no")
		{
            Console.WriteLine("Thanks!");
			Thread.Sleep(1500);
			return false;
		}
		else
		{
			Console.WriteLine("Please enter y or n");
		}
	}
}