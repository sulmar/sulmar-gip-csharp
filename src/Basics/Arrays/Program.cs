// # Arrays

string[] selectedColors = new string[] { "red", "blue", "green" };

// Iteracja po wszystkich elementach tablicy
foreach(string color in selectedColors)
{
    Console.WriteLine(color);
}

// Pobranie elementu z tablicy na podstawie indeksu
Console.WriteLine(selectedColors[1]);

// Ustawienie elementu w tablicy na podstawie indeksu
selectedColors[1] = "yellow";
Console.WriteLine(selectedColors[1]);

Console.WriteLine(selectedColors.Length);

char[] letters = new char[5];
letters[1] = 'A';
letters[3] = 'B';
letters[4] = 'C';

foreach(char c in letters)
{
    Console.WriteLine(c); 
}

Console.WriteLine(letters.Length);

char[,] chessBoard = new char[8,8];
chessBoard[0, 0] = 'W';
chessBoard[0, 1] = 'S';
chessBoard[0, 2] = 'G';

// zła praktyka
string[] customers = new string[10000];

// dobra praktyka - zastosuj Listy!













