// More fun with dictionaries

//A list of salaries. The key will be a person's name (string.)
//and the value will be the person's salary (decimal.)

Dictionary<string, decimal> salaries = new Dictionary<string, decimal>();
salaries["Paul"] = 65000m;
salaries["Sarah"] = 100000m;
salaries["Quincy"] = 80000m;
salaries["Ruby"] = 65000m;
salaries["Terry"] = 60000m;
salaries["Fidan"] = 250000m;


//foreach (var pair in salaries)
//{
//    Console.WriteLine(pair.Key);
//}

foreach (string key in salaries.Keys)
{
    Console.WriteLine(key);
}

Console.Write("Please enter a name:\t");
string name = Console.ReadLine();


if (salaries.ContainsKey(name))
{
    Console.WriteLine(salaries[name]);
}
else
{
    Console.WriteLine("We don't have record of this person. ");
}

Console.Write("Please add a new employee. Enter their name: ");
name = Console.ReadLine();
Console.Write("Please insert their salary: ");
string entry = Console.ReadLine();
decimal salary = Convert.ToDecimal(entry);

//We have 2 ways of adding to a dictionary 
//salaries[name] = salary;
salaries.Add(entry, salary);

Console.WriteLine("Here is everybody");
foreach (var pair in salaries)
{
    Console.WriteLine($"{pair.Key} makes {pair.Value}");
}