
string sentence = "Hello there everybody from planet earth.";

string[] words = sentence.Split();

foreach (string word in words)
{
    Console.WriteLine(word);
}
Console.WriteLine();
Console.WriteLine("Split by commas: ");
sentence = "Hello,there,everybody,from,planet,earth!";

char[] delims = { ',', ' ' }; //split by comma or space
words = sentence.Split(delims);
foreach (string word in words)
{
    Console.WriteLine(word);
}


//Let's join these words back together

sentence = string.Join(';', words);
Console.WriteLine(sentence);

//Let's try with spaces

sentence = string.Join(' ', words);  // nount dot verb, the nount is a teype, in this case string. 
                                        //Methods that are attached to the type itself are called "statid" methods
                                        //Methods that are attached to an instance of the type (such as sentence) are called instance methods
Console.WriteLine(sentence);


//Let's find the position of a letter in a string.
//IndexOf uses a commen approach: It returns a 0-based index, or a -1 if it doesn't find it.
Console.WriteLine();
Console.WriteLine("IndexOf practice");
sentence = "We will find a letter position";
Console.WriteLine(sentence.IndexOf('i'));
Console.WriteLine(sentence.IndexOf('x'));
Console.WriteLine(sentence.LastIndexOf('i'));
Console.WriteLine(sentence.LastIndexOf('x'));

//Let's use the substring method. This will find a piece of a string
Console.WriteLine();
Console.WriteLine("Substring practice");
sentence = "Hello world";
Console.WriteLine(sentence.Substring(1)); //Expect "ello World"
Console.WriteLine(sentence.Substring(3)); //Expect "lo World"
Console.WriteLine(sentence.Substring(4, 3)); //Expect "o w"