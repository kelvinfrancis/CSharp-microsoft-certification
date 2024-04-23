namespace exercise_conditional_operator;

class Program
{
    static void Main(string[] args)
    {
        // int saleAmount = 1001;
        // System.Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

        // CHALLENGE 1 - flip coin
        // recreate the flip of a coin
        // Random coin = new Random();
        // int flip = coin.Next(0, 2);
        // System.Console.WriteLine(flip == 0 ? "Heads" : "Tails");

        // CHALLENGE 2 - DECISION LOGIC
        string permission = "Admin|Manager";
        int level = 19;

        if (permission.Contains("Admin"))
        {
            if (level > 55)
                Console.WriteLine("Welcome, Super Admin user.");
            else
                Console.WriteLine("Welcome, Admin user.");
        }
        else if (permission.Contains("Manager"))
        {
            if (level > 20)
                Console.WriteLine("Contact an Admin for access.");
            else
                Console.WriteLine("You do not have sufficient privileges.");
        }
        else
            Console.WriteLine("You do not have sufficient privileges.");
    }
}
