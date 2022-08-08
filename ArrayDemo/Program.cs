// An array is a variable that can hold a list of things
int[] grades = {100, 80, 100, 60, 85};

Console.WriteLine(grades[0]); // 100
Console.WriteLine(grades[1]); //80
Console.WriteLine(grades[4]); //85

string[] names = { "Fred", "Jamal", "Yasmine", "Ziggy" };
Console.WriteLine(names[0]);
Console.WriteLine(names[2]);


Console.WriteLine();
int index = 3;
Console.WriteLine(names[index]); //Same as names [3], expect to see Ziggy

Console.WriteLine();
for (int ind = 0; ind < 4; ind++)
{
    Console.WriteLine(names[ind]);
}

Console.WriteLine();
//Same thing, but let's use <= 3 instead. 

for (int ind = 0; ind <= 3; ind++) //This clearly shows the start and the end
{
    Console.WriteLine(names[ind]);
}

// Let's change one. Suppose we misspelled the 3rd name. Should be Jasmine
// We are changing the entire string, replacing it. Strings are immutable. We can't change an individual letter.
names[2] = "Jasmine";
Console.WriteLine();
Console.WriteLine($"We correct the spelling of {names[2]}");

//Let's change the first grade 
grades[0] = 99;
Console.WriteLine($"The first grade is now {grades[0]}");

