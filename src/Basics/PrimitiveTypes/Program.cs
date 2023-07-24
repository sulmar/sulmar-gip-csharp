// PrimitiveTypes

// Texts

string name = "Marcin";  // String Literal (literał tekstowy)

string selectedColor = null;

selectedColor = "Red";

char sign = 'A'; // Char Literal

char firstSign = name[0];


// Numbers

// Integer (całkowite)

byte age = 18; // 0...255
Console.WriteLine($"byte {byte.MinValue}...{byte.MaxValue}");

short deep = -9000; // +/- 2^15
Console.WriteLine($"short {short.MinValue}...{short.MaxValue}");

ushort altitude = 9000;  // 2^16
Console.WriteLine($"ushort {ushort.MinValue}...{ushort.MaxValue}");

int invoiceId = 9999; // +/- 2^31
Console.WriteLine($"int {int.MinValue}...{int.MaxValue}");

uint customerId = 9999; // 2^32
Console.WriteLine($"uint {uint.MinValue}...{uint.MaxValue}");

long trackingId = 999999; // 1 + 2^63
Console.WriteLine($"long {long.MinValue}...{long.MaxValue}");

// Real (rzeczywiste)

float temperature = 21.04f; // 16-bitowa
Console.WriteLine($"float {float.MinValue}...{float.MaxValue}");

double width = 0.000001; // 32-bitowa
Console.WriteLine($"double {double.MinValue}...{double.MaxValue}");

decimal unitPrice = 199.99m; // 64-bitowa
Console.WriteLine($"decimal {decimal.MinValue}...{decimal.MaxValue}");


// Boolean
bool isApproved = false; // Boolean Literal


// Daty i czas

DateTime currentDate = DateTime.Now;
TimeSpan startMeetingHour = TimeSpan.Parse("09:00");

DateOnly dueDate = DateOnly.ParseExact("2023-07-24", "yyyy-MM-dd");
TimeOnly openingHour = TimeOnly.ParseExact("09:00", "HH:mm");

Console.WriteLine(startMeetingHour);
Console.WriteLine(currentDate);
Console.WriteLine(dueDate);
Console.WriteLine(openingHour);







