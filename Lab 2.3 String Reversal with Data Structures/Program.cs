using System.Threading.Tasks;

string forwardString = "";
do
{

Console.WriteLine("Please insert a string, and I will flip it and reverse it!");
Console.WriteLine("__________________________________________________________\n");
forwardString = Console.ReadLine();
Console.WriteLine();
Console.Write($"Your string in reverse is: ");
ReverseIt(forwardString);
Console.WriteLine();
Thread.Sleep(1000);
} while (KeepGoing());

static string ReverseIt(string forwardString)
{

    char[] convertToChar = forwardString.ToCharArray();
    Stack<char> stack = new Stack<char>();
    foreach (char c in convertToChar)
    {
        stack.Push(c);
    }
    while (stack.Count > 0)
    {
        char charReversed = stack.Pop();
        Console.Write(charReversed);
    }
    return string.Format(forwardString);
}


static bool KeepGoing()
{
	while (true)
	{
		// Print out message asking if user wants to continue
		Console.WriteLine("Would you like to go again? (y/n)");
		// Ask the user for their input
		string response = Console.ReadLine();
		response = response.ToLower();
		// Check if they typed "y". If so, return true.
		// Otherwise return false.   YES   yes
		if (response == "y" || response == "yes")
		{
			return true;
		}
		else if (response == "n" || response == "no")
		{
			return false;
		}
		else
		{
			Console.WriteLine("Please enter y or n");
		}
	}
}


