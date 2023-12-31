﻿// #Enums (typ wyliczeniowy)

OrderStatus status = OrderStatus.Delivered;

if (status == OrderStatus.Registered)
{
    Console.WriteLine("Zamówienie zostało przyjęte.");
}
else if (status == OrderStatus.Shipping)
{
    Console.WriteLine("Przesyłka jest w drodze do Ciebie.");
}
else if (status == OrderStatus.Delivered)
{
    Console.WriteLine("Przesyłka została dostarczona.");
}

// Konwersja enum na liczbę
byte statusNumber = (byte) status;
Console.WriteLine(statusNumber);

// Konwersja enum na tekst
string statusString = status.ToString();
Console.WriteLine(statusString);

// Konwersja liczby na enum
OrderStatus orderStatusFromNumber = (OrderStatus)2;
Console.WriteLine(orderStatusFromNumber);

// Konwersja tekstu na enum
OrderStatus orderStatusFromString = Enum.Parse<OrderStatus>("Shipping");
Console.WriteLine(orderStatusFromString);


// TODO:
// Utwórz aplikację, która na podstawie statusu dokumentu wyświetl komunikat: 

// Jeśli** Draft** to "Dokument w trakcie edycji"
// Jeśli **Accept** to "Dokument został zatwierdzony"

// Hint: zastosuj enum

Console.Write("Podaj status: ");
string? documentStatusString = Console.ReadLine();

if (documentStatusString != null)
{
    bool isValid = Enum.TryParse(documentStatusString, out DocumentStatus documentStatus);

    if (isValid)
    {
        if (documentStatus == DocumentStatus.Draft)
        {
            Console.WriteLine("Dokument w trakcie edycji");
        }
        else if (documentStatus == DocumentStatus.Accept)
        {
            Console.WriteLine("Dokument został zatwierdzony");
        }
    }
    else
    {
        Console.WriteLine("Nieobsługiwany status dokumentu");
    }
}

// 0 - Registered
// 1 - Shipping
// 2 - Cancelled
// 3 - Delivered

enum OrderStatus
{
    Registered,
    Shipping,
    Cancelled,
    Delivered
}

enum DocumentStatus
{
    Draft,
    Accept
}