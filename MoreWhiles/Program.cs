int x = 0;

//while (10 > 9)
//{
//    //This will run forever
//    Console.WriteLine($"While loop. x is {x}");
//    x++;
//}

//while (9 > 10)
//{
//    // 9 > 10 is a false statemtn. So this code will never run. 
//    Console.WriteLine($"While loop. x is {x}");
//
//

bool done = false;

while(!done)
{
    Console.WriteLine($"While loop. x is {x}");
    x++;

    if (x == 10000)
    {
        done = true;
    }

}

Console.WriteLine($"All done for the day! x is now {x}");