//Let's make an array for comparison
string[] myArray = { "abc", "def", "ghi" };

Console.WriteLine(myArray[0]);

//Let's change one of the members
myArray[1] = "jkl";

//Let's loop through it
for (int ind = 0; ind < myArray.Length; ind++)
{
    Console.WriteLine(myArray[ind]);
}

Console.WriteLine();

//
// No let's use a List
//

List<string> myList = new List<string>();
myList.Add("Abc");
myList.Add("Def");
myList.Add("Ghi");

//Let's print out one element
Console.WriteLine(myList[0]);

//Let's change one of the elements
myList[1] = "Jkl";

//Let's add another one
myList.Add("Mno");

for (int ind = 0; ind < myList.Count; ind++) //use.count for maximum lenght of list
{
    Console.WriteLine(myList[ind]);
}

//Delete one from the list
//Insert one into the list 
//We'll look at the official documentation

Console.WriteLine("Let's remove the one at index 2");
myList.RemoveAt(2);

for (int ind = 0; ind < myList.Count; ind++) //use.count for maximum lenght of list
{
    Console.WriteLine(myList[ind]);
}

Console.WriteLine("Let's remove one by name");
myList.Remove("Abc");

for (int ind = 0; ind < myList.Count; ind++) //use.count for maximum lenght of list
{
    Console.WriteLine(myList[ind]);
}

Console.WriteLine("Now let's insert one ine betwen the first two. ");
myList.Insert(1, "Pqr");

foreach (string word in myList)  // a foreach loop is an easier way to print out all items in a list. 
{
    // We can't see the index 
    Console.WriteLine(word);
}


// Some functions modify the list. They actually do change the list itself. Unlike string function.s

Console.WriteLine("Let's sort the list");
myList.Sort();                                 //Sort method will alphabetize the list
foreach (string word in myList)  // a foreach loop is an easier way to print out all items in a list. 
{
    // We can't see the index 
    Console.WriteLine(word);
}

// Here we will check if somethign exists in the list 
Console.WriteLine("Type in a word and we'll see if it's in the list.");
string entry = Console.ReadLine();
int index = myList.IndexOf(entry);
if (index >= 0)
{
    Console.WriteLine($"found {entry} at {index}.");
}
else
{
    //In this case we got back a -1 meaning it wasn't found
    Console.WriteLine($"Sorry, {entry} is not in the list");
}




//Let's initalize a  list
Console.WriteLine("Let's initialize a list of integers.");
List<int> numbers = new List<int>() { 5, 3, 8, 2 };
foreach (int nextnum in numbers)
{
    Console.WriteLine($"The next number is {nextnum}");
}
