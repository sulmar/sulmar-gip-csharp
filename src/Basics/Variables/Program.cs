// Variables

// Statyczne typowanie

string name = "Marcin";

// Notacja Pascal-Case (notacja Pascalowa)
Console.WriteLine(name);

// Notacja Camel-Case (notacja wielbłądzia)
string lastName = "Sulecki";

Console.WriteLine(lastName);

// Notacja Snake-Case (notacja wężowa)
string last_name = "Sulecki";


// Konkatenacja

// zła praktyka
// string fullName = name + " " + lastName;

// Console.WriteLine(name + " " + lastName);
// Console.WriteLine(fullName);

// Garbage collector

// Interpolacja
// dobra praktyka
string fullName = $"{name} {lastName}";
Console.WriteLine(fullName);





