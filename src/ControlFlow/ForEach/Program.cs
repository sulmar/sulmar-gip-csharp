
string[] names = new string[] { "Marcin", "Agnieszka", "Damian", "Michał", "MichałH" };

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{i} {names[i]}");
}

foreach (string name in names)
{
    int index = Array.IndexOf(names, name);
    Console.WriteLine($"{++index} {name}");
}

bool[,] board = new bool[3, 3];
board[0, 0] = true;
board[0, 1] = true;
board[0, 2] = true;
board[1, 0] = true;

for (int row = 0; row < board.GetLength(0); row++)
{
    for (int column = 0; column < board.GetLength(1); column++)
    {
        Console.WriteLine($"[{row},{column}] = {board[row, column]}");
    }
}


