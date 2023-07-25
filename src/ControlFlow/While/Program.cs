
int i = 1;

/*

    while(condition)
    {
      statement
    }

*/

while (i <= 5)
{
    Console.WriteLine("Hello World!");
    i++;
}

bool isConnected = true;

Random random = new Random();

while (isConnected)
{
    Console.WriteLine(random.Next(20, 100));

    Thread.Sleep(1000);
}