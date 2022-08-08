while (true)
{

    Console.WriteLine("Please enter an integer. ");
    string entry = Console.ReadLine();

    int num;

    bool result = int.TryParse(entry, out num); //2 paramaters. The first is the string we are trying to test, the second is the out.
    if (result == true)
    {
        Console.WriteLine($"Great! Your number is {num}");
    }
    else
    {
        Console.WriteLine($"Sorry, {entry} is not an integer");
    }

}




