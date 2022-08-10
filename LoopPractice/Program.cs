string sentence = "";  // These variables need to be accessed outside of the loops, so they are declared outside
string word = "";
do
{

    bool valid = false;

    while (!valid) //This is going to repeat as long as it is not a valid response. This is what needs to repeat until it is true
    {
        Console.Write("Please insert a full sentence: ");
        sentence = Console.ReadLine();
        if (sentence.Contains(" "))
        {
            valid = true;
        }
        else
        {
            Console.WriteLine("Makes sure your sentence contains at least one space.");
        }
    }
    valid = false;
    while (!valid) //This is the reverse. The bool is starting off false. when it is true, we will break out of the loop
    {
        Console.Write("Please enter a word: ");
        word = Console.ReadLine();

        if (word.Contains(" "))
        {
            Console.WriteLine("Make sure you enter a word with no spaces");
        }
        else
        {
            valid = true;
        }
    }

    bool contains = sentence.ToLower().Contains(word.ToLower());
    if (contains)
    {
        Console.WriteLine("Yes, that word exists in the senctence");
    }
    else
    {
        Console.WriteLine("No, that word does not exist in the sentence");
    }

}
while (KeepGoing());



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
