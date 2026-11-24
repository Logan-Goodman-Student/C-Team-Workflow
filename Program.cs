Console.WriteLine("These next 4 questions were made by me.");
int score = 0;
void WyattQuestion1()
{
Console.WriteLine("Where was Michael De Santa's first score located?");
Console.WriteLine("1. Liberty City");
Console.WriteLine("2. Carcer City");
Console.WriteLine("3. Los Santos");
Console.WriteLine("4. North Yankton");

string userScore = Console.ReadLine();
int answer = int.Parse(userScore);
if(answer == 1 || answer == 2 || answer == 3 || answer == 4)
{
    if(answer == 2)
    {
        Console.WriteLine("That's correct!");
        playerScore++;
    }
    else
    Console.WriteLine("Wrong");
}
else
{
    Console.WriteLine("That's not one of the options, so you're wrong");
}
}

WyattQuestion1();

Console.WriteLine("Next Question");

void WyattQuestion2()
{
    Console.WriteLine("Which of these rivers run through Egypt?");
    Console.WriteLine("1. The Amazon");
    Console.WriteLine("2. The Mississippi");
    Console.WriteLine("3. The Rhine");
    Console.WriteLine("4. The Nile");


string userScore = Console.ReadLine();
int answer = int.Parse(userScore);
if(answer == 1 || answer == 2 || answer == 3 || answer == 4)
{
    if(answer == 4)
    {
        Console.WriteLine("That's correct!");
        score++;
    }
    else
    Console.WriteLine("Wrong");
}
else
{
    Console.WriteLine("That's not one of the options, so you're wrong");
}
}

WyattQuestion2();

Console.WriteLine("Next Question");


void WyattQuestion3()
{
    Console.WriteLine("When did the Mayan calendar end?");
    Console.WriteLine("1. 2012");
    Console.WriteLine("2. 2000");
    Console.WriteLine("3. 2020");
    Console.WriteLine("4. 2016");


    string userScore = Console.ReadLine();
int answer = int.Parse(userScore);
if(answer == 1 || answer == 2 || answer == 3 || answer == 4)
{
    if(answer == 1)
    {
        Console.WriteLine("That's correct!");
        score++;
    }
    else
    Console.WriteLine("Wrong");
}
else
{
    Console.WriteLine("That's not one of the options, so you're wrong");
}
}

WyattQuestion3();

Console.WriteLine("Next Question");

void WyattQuestion4()
{
    Console.WriteLine("What is the name of the protagonist in Red Dead Redemption?");
    Console.WriteLine("1. Red Harlow");
    Console.WriteLine("2. John Marston");
    Console.WriteLine("3. Arthur Morgan");
    Console.WriteLine("4. Niko Bellic");
    
    string userScore = Console.ReadLine();
int answer = int.Parse(userScore);
if(answer == 1 || answer == 2 || answer == 3 || answer == 4)
{
    if(answer == 2)
    {
        Console.WriteLine("That's correct!");
        score++;
    }
    else
    Console.WriteLine("Wrong");
}
else
{
    Console.WriteLine("That's not one of the options, so you're wrong");
}
}

WyattQuestion4();
Console.WriteLine("You got " + score + " out of 4 questions correct.");