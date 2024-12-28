bool validEntry = false;

int number;
Console.WriteLine("Enter a number between 5 and 10:");
do
{
    number = Convert.ToInt32(Console.ReadLine());
    if (number >= 5 && number <= 10)
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine("Your input is invalid. Please try again.");
    }
} while (validEntry == false);
Console.WriteLine($"Number:{number}. Power of 2 is {Math.Pow(number, 2)}");

// Pisanie kodu weryfikujacy dane
// Uzywanie Trim(), ToLower()
// String musi zawierac opcje: Administrator, Manager albo User.
string? name;
validEntry = false;
Console.WriteLine("Enter your role name (Administrator, Manager or User)");
do
{
    name = Console.ReadLine();
    if (name != null)
    {
        var lower = name.Trim().ToLower();
        if (lower == "admin" || lower == "manager" || lower == "user")
        {
            Console.WriteLine($"Your value ({lower}) has been accepted.");
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid. Please try again.");
        }
    }
} while (validEntry == false);
// Zadanie 3: pisanie kodu przetwarzającego zawartość tablicy ciągów
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string myString in myStrings)
{
    // Index pierwszej kropki
    int periodLocation = myString.IndexOf('.');
    string temp = myString;
    while (periodLocation != -1)
    {
        //Wyodrebnienie zdania do kropki
        string sentence = temp.Substring(0, periodLocation).TrimStart();
        Console.WriteLine(sentence);
        temp = temp.Remove(0, periodLocation + 1).TrimStart();
        periodLocation = temp.IndexOf('.');
    }

    if (!string.IsNullOrWhiteSpace(temp))
    {
        Console.WriteLine(temp);
    }
}