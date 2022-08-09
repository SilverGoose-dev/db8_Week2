// Let's start with a list for comparison

List<string> letters = new List<string>();
letters.Add("Abc");
letters.Add("Def");
letters.Add("Ghi");
letters.Add("Jkl");
letters.Add("Mno");

Console.WriteLine("Here are the letters");
foreach (string next in letters)
{
    Console.WriteLine(next);
}

// Now let's build a dictionary they use key-value (lookup term - definition)
//Dictionaries do not have indexes. They are unordered by design, like a database. 
Dictionary<string, string> foods = new Dictionary<string, string>();
foods["Paul"] = "Spaghetti";
foods["Sarah"] = "Pizza";
foods["Quincy"] = "Tacos";
foods["Ruby"] = "Ice Cream";
foods["Terry"] = "Tacos";

//Let's print out Ruby's favorite food
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Here is Ruby's favorite food");
Console.WriteLine(foods["Ruby"]);

//Paul changed his mind. He likes Hamburgers.
foods["Paul"] = "Hamburgers";
Console.WriteLine($"Paul now likes {foods["Paul"]}");

//Do not assume a fixed order! If you need ordereing, use a list. 
foreach (var pair in foods)
{
    Console.WriteLine($"The name and the food are:");
    Console.WriteLine(pair.Key); //Persons name
    Console.WriteLine(pair.Value); //Their favorite food 
}

//Check if an items exists in the dictionary

string entry = Console.ReadLine();
if (foods.ContainsKey(entry))
{
    Console.WriteLine($"Yes, we have a favorite food for {entry}");
    Console.WriteLine(foods[entry]);
}
else
{
    Console.WriteLine("We don't have a record of that person.");
}