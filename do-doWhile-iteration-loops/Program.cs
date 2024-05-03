Random random = new Random();
int current = random.Next(1, 11);

// do 
// {
//     current = random.Next(1,11);
//     Console.WriteLine(current);
// } while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1,11);
// }
// Console.WriteLine($"Last number: {current}");

// do
// {
//     current = random.Next(1,11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// CHALLEGE - Role playing game battle challenge
// Random dice = new Random();

// int heroHealth = 10;
// int mosterHealth = 10;
// int attack = 0;

// do
// {
//     attack = dice.Next(1,11);
//     mosterHealth -= attack;
//     Console.WriteLine($"Monster was damaged and lost {attack} health and now has {mosterHealth} health.");
//     if (mosterHealth <= 0 ) break;
    
//     attack = dice.Next(1,11);
//     heroHealth -= attack;
//     Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");

// } while (heroHealth > 0 && mosterHealth > 0);
// Console.WriteLine(heroHealth <= 0 ? "Monster wins!": "Hero wins!");

//  CHALLENGE - differentiate between do and while iteration statements
// Manage user input during this challenge
// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry= true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);

// Code Project 1 - write code that validates integer input
/*
Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

-Your solution must use a Console.ReadLine() statement to obtain input from the user.
-Your solution must ensure that the input is a valid representation of an integer.
-If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
-Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
-Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/
/**********************************************************************************/
// Console.WriteLine("Enter a value between 5 and 10: ");
// int value = 0;
// bool validNum = false;
// do
// {
//     validNum = int.TryParse(Console.ReadLine(), out value);

//     if ( (value > 5 && value < 10) || !validNum)
//         Console.WriteLine("Invalid value. Please enter a value between 5 and 10: ");
// } while (value > 5 && value < 10 || !validNum);

// Console.WriteLine($"Your value ({value}) has been accepted. ");
/**********************************************************************************/

// Code project 2 - write code that validates string input

// Console.WriteLine("Enter the Role (Administrator, Manager or User):");
// string? role = null;
// do
// {
//     role = Console.ReadLine().Trim().ToLower();
//     if (role != "administrator" && role != "manager" && role != "user")
//         Console.WriteLine($"The role name that you entered, '{role}' is not valid. Enter your role name (Administrator, Manager, or User");

// } while (role != "administrator" && role != "manager" && role != "user");
// Console.WriteLine($"Your role ({role.ToUpper()}) has been accepted.");
/**********************************************************************************/
// Code project 3 - Write code that processes the contents of a string array
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {
        // first sentence
        mySentence = myString.Remove(periodLocation);

        // remainder value of myString
        myString = myString.Substring(periodLocation + 1);

        // remove white-space at front
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}