//prompt the user to enter a number between 1 and 100

// odd and < 60 Print $"{userNumber} is odd and less than 60"

// even and between 2 and 24 Print $"{userNumber} is even and less than 25"

//even and between 26= to =60, print $“{userNumber} is even and between 26 and 60 inclusive.”

//even and greater than 60, print the number entered and $“{userNumber} Even and greater than 60.”

//odd and greater than 60, print the number entered and $“{userNumber} Odd and greater than 60.”

Console.WriteLine("Hi, welcome to the Number Analyzer! What is your name?");
    string userName = Console.ReadLine();
while (true)
{
    
    Console.WriteLine($"Ok, {userName}, please choose a number between 1 and 100 or type \"quit\" to stop playing.");
    string input = Console.ReadLine();
    int userNumber;
    int.TryParse(input, out userNumber);
    int remainder = userNumber % 2;

    if(input == "quit")
    {
        break;
    }

    else if(userNumber < 1 || userNumber > 100)
    {
        Console.WriteLine($"{userName}, that is literally not what I asked for... Try again.");
    }
    else if (remainder != 0 && userNumber < 60)
    {
        Console.WriteLine($"{userName} the number, {userNumber} is odd and less than 60!");
    }
    else if(remainder == 0 && userNumber < 25)
    {
        Console.WriteLine($"So cool, {userName}, {userNumber} is even and less than 25");
    }
    else if(remainder == 0 && userNumber >= 26 &&  userNumber <= 60)
    {
        Console.WriteLine($"{userNumber} is an even number between 26 and 60, inclusive. So cool, I love it, {userName}");
    }
    else if( remainder == 0 && userNumber > 60)
    {
        Console.WriteLine($"Cool number, {userName}, {userNumber} is even and larger than 60.");
    }
    else if( remainder != 0 && userNumber > 60)
    {
        Console.WriteLine($"Really cool number you picked, {userName}, {userNumber} is odd and greater than 60. Amazing.");
    }
        
    }


