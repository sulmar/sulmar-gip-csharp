
using System;

const int speedLimit = 70;
const int perPoint = 5;
const int pointsLimit = 12;

while (true)
{
    Console.Write("Podaj prędkość: ");
    string speedString = Console.ReadLine();

    int speed = int.Parse(speedString);

    Check(speed);
   
}

void Check(int speed)
{
    if (speed <= speedLimit)
    {
        Console.WriteLine("OK");
    }
    else
    {
        int exceedSpeed = speed - speedLimit;

        double points = (double)exceedSpeed / perPoint;

        points = (double)Math.Ceiling(points);

        if (points >= pointsLimit)
        {
            Console.WriteLine("License suspended.");
        }
        else
        {
            Console.WriteLine($"Points {points}");
        }
    }
}