// ## Comparison

int x = 1;

// Relational
Console.WriteLine(x > 0); // True
Console.WriteLine(x >= 1); // True
Console.WriteLine(x < 1); // False
Console.WriteLine(x <= 1); // True

// Equality
Console.WriteLine(x == 1); // True
Console.WriteLine(x != 1); // False

byte bateryLevel = 90;

const byte bateryLevelLowLimit = 30;
const byte bateryLevelHightLimit = 80;

bool isLowBateryLevel = bateryLevel < bateryLevelLowLimit;

if (isLowBateryLevel)
{
    Console.WriteLine("Please plugin your phone to charger.");
}

BateryLevel level;

if (bateryLevel < bateryLevelLowLimit)
{
    level = BateryLevel.Low;
}
else if (bateryLevel >= bateryLevelLowLimit && bateryLevel < bateryLevelHightLimit)
{
    level = BateryLevel.Medium;
}
else
{
    level = BateryLevel.Hight;
}

Console.WriteLine(level);

enum BateryLevel
{
    Low,
    Medium,
    Hight
}

