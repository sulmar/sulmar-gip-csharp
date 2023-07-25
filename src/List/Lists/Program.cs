
// string[] members = new string[] { "Marcin", "Agnieszka" };

List<string> members = new List<string>()
{
    "Marcin",
    "Agnieszka"
};

members.Add("Michał");
members.Add("MichałH");
members.Add("Damian");

members[0] = "Bartek";

members.Remove("Damian");

if (!members.Contains("Marcin"))
{
    Console.WriteLine("A gdzie Marcin?!");
}

Display(members);

members.Clear();



Console.WriteLine("Clear called!");

Display(members);

void Display(List<string> members)
{
    foreach (string member in members)
    {
        Console.WriteLine(member);
    }
}








