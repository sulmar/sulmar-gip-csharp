// Hour
// If hour is between 6am and 12am: Good morning!
// If it is between 12am and 6pm: Good afternoon!
// Otherwise: Good evening!

byte hour = 18;

/*
    if (condition)
    {
        statement
    }
    else if (anotherCondition)
    {
        statment
    }
    else
    {
        statment
    }
*/

// && - AND logiczny
if (hour >= 6 && hour < 12)
{
    Console.WriteLine("Good morning!");
}
else if (hour >= 12 && hour < 18)
{
    Console.WriteLine("Good afternoon!");
}
else
{
    Console.WriteLine("Good evening!");
}
