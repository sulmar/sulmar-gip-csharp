// ## Bitwise Operators

// 1 = 0000 0001
// 2 = 0000 0010
// 3 = 0000 0011

// Bitwise OR
Console.WriteLine(1 | 2);

// 1 = 0000 0001
// 2 = 0000 0010
// R = 0000 0000

// Bitwise AND
Console.WriteLine(1 & 2);

// Read, Write, Execute


// 0100 - Read // 1*2^2 + 0*2^1+ 0*2^0 = 4
// 0010 - Write
// 0001 - Execute

const byte readPermission = 4; 
const byte writePermission = 2;
const byte executePermission = 1;

int myPermission = 0;

myPermission = myPermission | readPermission | writePermission; // suma logiczna
Console.WriteLine(myPermission);

bool canReadPermission = (myPermission & readPermission) == readPermission;

if (canReadPermission)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}

Permission permission = Permission.Read | Permission.Write;

bool canWritePermission = permission.HasFlag(Permission.Write);

Console.WriteLine(canWritePermission);


enum Permission
{
    Read = 4,
    Write = 2,
    Execute = 1,
}











