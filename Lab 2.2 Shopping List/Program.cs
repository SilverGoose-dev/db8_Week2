using System.Threading.Tasks;
decimal total = 0;
bool validSearch = false;
bool validEntry = false;
List<string> shoppingCart = new List<string>();
Dictionary<string, decimal> inventory = new Dictionary<string, decimal>();
inventory.Add("Milk", 1.99m);
inventory.Add("Eggs", 1.50m);
inventory.Add("Chicken", 5.25m);
inventory.Add("Beer", 12.99m);
inventory.Add("Potato",3.99m);
inventory.Add("Peppers", 0.99m);
inventory.Add("Rice", 4.99m);
inventory.Add("Onions", 1.25m);
inventory.Add("Coffee", 6.99m);
inventory.Add("Water", 1.99m);


string chosenProduct = "";

do
{
    Menu();
    validSearch = false;
    validEntry = false;
    while (!validSearch)
    {
        Console.Write("\n\nPlease enter a product: ");
        string entry = Console.ReadLine();

        if (inventory.ContainsKey(entry))
        {
            chosenProduct = entry;
            validSearch = true;
        }
    }

    if (validSearch)
    {

        Console.WriteLine($"Here is the item {chosenProduct}, and it costs {inventory[chosenProduct]}");
        Thread.Sleep(1000);

        bool addProduct = false;
        while (!validEntry)
        {
            Console.Write("Would you like to add this to your cart? (Y or N):\t");
            // Get an answer of yes or no
            string userEntry = Console.ReadLine().ToLower();
            if (userEntry == "yes" || userEntry == "y")
            {
                validEntry = true;
                addProduct = true;

            }
            else if (userEntry == "no" || userEntry == "n")
            {
                Thread.Sleep(1000);
                validEntry = true;
                addProduct = false;
            }
            else
            {
                Console.WriteLine("That is not a valid answer.");
            }
        }

        if (addProduct)
        {
            Console.WriteLine("Got it! Adding item to your cart!");
            shoppingCart.Add(chosenProduct);
            total += inventory[chosenProduct];
            Console.WriteLine($"Your current total is {total}");
        }
    }
} while (KeepGoing());

Console.WriteLine("Here is your cart and total!");
foreach (var entry in shoppingCart)
{
    Console.WriteLine($"***{entry}");
}
    Console.WriteLine($"Your grand total is ${total}");
static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.Write("\nWould you like to continue shopping? (y/n):\t");
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

void Menu()
{
    int itemNumber = 1;
    Console.WriteLine("Big Al's SuperStore!");
    Console.WriteLine("====================");
    foreach (var food in inventory)
    {
        Console.WriteLine($"{itemNumber}, {food.Key}: ${food.Value}");
    }
    Console.WriteLine("====================");
}