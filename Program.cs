//Jessie Lamzon
//10/18/22
//GitHubChallenge - Redo mini Challenges
//Greater than or less than, data validation and play again

Console.Clear();

string playAgain = "yes";

while (playAgain != "no")
{
    int numbr1 = 0;
    int numbr2 = 0;
    bool trueNum1 = true;
    bool trueNum2 = true;

    Console.WriteLine("Hello, what is your name?");
    string myName = Console.ReadLine();
    Console.WriteLine($"Hello {myName}");

    while (true)
    {
        Console.WriteLine("Please enter a number");
        string num1 = Console.ReadLine();
        trueNum1 = int.TryParse(num1, out numbr1);

        if (trueNum1 == true)
        {
            break;
        }
        else if (trueNum1 == false)
        {
            Console.WriteLine("Please enter the correct format");
        }
    }

    Console.WriteLine("Please enter another number");
    string num2 = Console.ReadLine();
    trueNum2 = int.TryParse(num2, out numbr2);

    // int numbr1 = Convert.ToInt32(num1);
    // int numbr2 = Convert.ToInt32(num2);

    if (numbr1 > numbr2)
    {
        Console.WriteLine(numbr1 + " is greater than " + numbr2);
        Console.WriteLine(numbr2 + " is less than " + numbr1);
    }
    else if (numbr1 < numbr2)
    {
        Console.WriteLine(numbr2 + " is greater than " + numbr1);
        Console.WriteLine(numbr1 + " is less than " + numbr2);
    }
    else if (numbr1 == numbr2)
    {
        Console.WriteLine("These numbers are equal.");
    }

    Console.WriteLine("Would you like to play again? yes/no");

    playAgain = Console.ReadLine();
}


Console.WriteLine("Thanks for playing!");