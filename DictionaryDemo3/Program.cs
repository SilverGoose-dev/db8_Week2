// Let's do a dictionary like this:
//  1 "One"
//  10 "Ten"
// 20 twenty
// 100 to one hundred
// Key is int
//Value is String
Dictionary<int, string> numToWord = new Dictionary<int, string>();

numToWord.Add(01, "One");
numToWord.Add(10, "Ten");
numToWord.Add(20, "Twenty");
numToWord.Add(100, "One Hundred");

//Print out the keys
Console.WriteLine("Here are the keys: ");
foreach (int key in numToWord.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine();
Console.WriteLine("Here are the values");
foreach(string value in numToWord.Values)
{
    Console.WriteLine(value);
}