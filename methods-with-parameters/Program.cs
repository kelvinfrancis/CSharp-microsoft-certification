// int[] schedule = {800, 1200, 1600, 2000};

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }
//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }

//     for (int i = 0; i < times.Length; i++)
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }

// DisplayAdjustedTimes(schedule, 6, -6);

// ------------------- Exercise - Understand method scope
// using System.Net.NetworkInformation;

// double pi = 3.14159;
// PrintCircleInfo(12);
// PrintCircleInfo(24);

// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }

// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

//--------------- Exercise - Use value and reference type parameters
// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// void SetHealth(bool isHealthy) 
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

// ---------------- Exercise - Methods with optional parameters
// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) 
// {
//     if (inviteOnly)
//     {
//         // search guestList before adding rsvp
//         if (inviteOnly)
//         {
//             bool found = false;
//             foreach (string guest in guestList)
//             {
//                 if (guest.Equals(name))
//                 {
//                     found = true;
//                     break;
//                 }
//             }
//             if (!found)
//             {
//                 Console.WriteLine($"Sorry {name} is not on the guest list");
//                 return;
//             }
//         }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }

//-------------- Exercise - Complete the challenge to display email addresses
string[,] corporate =
{
    {"Robert", "Bavin"},
    {"Simon", "Bright"},
    {"Kim", "Sinclair"},
    {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"},
    {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"},
    {"Cody", "Dysart"},
    {"Shay", "Lawrence"},
    {"Daren", "Valdes"}
};
string internalDomain = "@contoso.com";
string externalDomain = "@hayworth.com";

GetEmail(corporate, internalDomain);
GetEmail(external, externalDomain);

void GetEmail(string[,] employees, string domain)
{
    for (int i = 0; i < employees.GetLength(0); i++)
    {
        // display internal email addresses
        string first2LettersName = employees[i, 0].Substring(0, 2);
        string lastName = employees[i, 1];
        string email = first2LettersName + lastName + domain;

        Console.WriteLine(email.ToLower());
    }
}