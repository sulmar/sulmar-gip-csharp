
GreetHelloWorld();

Greet("Marcin");
Greet("Agnieszka");
Greet("Michał");
Greet("MichałH");
Greet("Damian");

int result = Square(2);
Console.WriteLine(result);

int area = CalculateArea(2, 4);

Console.WriteLine(area);

// DRY (Don't Repeat Yourself)

void GreetHelloWorld()
{
    Console.WriteLine($"Hello, World!");
}

void Greet(string name)  // notacja Pascal-Case
{
    Console.WriteLine($"Witaj, {name}!");
}

int Square(int number)
{
    return number * number;
}

int CalculateArea(int width, int height)
{
    return width * height;
}

// (przeciwdziedzina) z = f(x, y) x, y należy do C (dziedzina funkcji)






