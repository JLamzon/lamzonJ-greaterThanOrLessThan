//Jessie Lamzon
//10/18/22
//GitHubChallenge - Redo mini Challenges
//Greater than or less than, data validation and play again
// Peer Review: Marcel R. The program runs well, no errors or anything. 
// It has play again functionality and will check if the number entered is an int. 
// Also has if else statements for different scenarios and uses break to break out. 
// One comment I have is that typing No for do you want to play again doesn't work, 
// but adding .ToLower() would be an easy fix. Awesome work!

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

//loops until correct format is met
    while (true)
    {
        Console.WriteLine("Please enter a number");
        string num1 = Console.ReadLine();
        trueNum1 = int.TryParse(num1, out numbr1);

//response to user input if correct or incorrect
        if (trueNum1 == true)
        {
            break;
        }
        else if (trueNum1 == false)
        {
            Console.WriteLine("Try again......");
        }
    }

//this while loops until correct format is met
    while (true)
    {
    Console.WriteLine("Please enter another number");
    string num2 = Console.ReadLine();
    trueNum2 = int.TryParse(num2, out numbr2);

//response to user input if correct or incorrect
            if (trueNum2 == true)
        {
            break;
        }
        else if (trueNum2 == false)
        {
            Console.WriteLine("Try again......");
        }
    }

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

    Console.WriteLine("Press any key to play again or type no......");

    playAgain = Console.ReadLine().ToLower();
}
Console.WriteLine("Thanks for playing!");