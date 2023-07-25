// https://blog.hackajob.com/better-c-switch-statements-for-a-range-of-values/

// Role
// If role is guest: Guest User
// If it is moderator or administrator: Moderator User
// Otherwise: Unknown User

string role = "a";

// TODO: Zapisz to za pomocą if-else

//if (role == "guest") Console.WriteLine("Guest User");
//else if (role == "moderator" || role == "administrator") Console.WriteLine("Moderator User");
//else Console.WriteLine("Unknown User");

switch(role)
{
    case "guest":
        Console.WriteLine("Guest User");
        break;
    case "moderator":
    case "administrator":
        Console.WriteLine("Moderator User");
        break;
    default: Console.WriteLine("Unknown User");
        break;
}

int bateryLevel = 20;

switch(bateryLevel)
{
    case > 0 and < 30:
        Console.WriteLine("Low");
        break;
    case >= 30 and < 70:
        Console.WriteLine("Medium");
        break;
    default:
        Console.WriteLine("Hight");
        break;
}

// Match Patterns


