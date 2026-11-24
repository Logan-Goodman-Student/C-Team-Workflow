await QuestionOne(0);
static async Task QuestionOne(int score)
{
    Random random = new Random();

    Console.WriteLine(
        "Welcome to our Trivia game! We will ask you 12 questions of completely unrelated topics.. how many can you get?"
    );
    Console.WriteLine(
        "================================================================================================================"
    );

    Console.WriteLine(
        "Question 1: Who won their 8th World Championship Title in MotoGP in Portugal, making history?"
    );

    string correctAnswer = "Marc Marquez";
    string fOneHistory = "Kimi Antonelli";

    string[] answers = { "Marc Marquez", "Kimi Antonelli", "Valentino Rossi", "Scottie Scheffler" };

    for (int i = answers.Length - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);

        string temporary = answers[i];
        answers[i] = answers[j];
        answers[j] = temporary;
    }

    string letters = "ABCD";

    for (int i = 0; i < answers.Length; i++)
    {
        Console.WriteLine($"{letters[i]}. {answers[i]}");
    }

    string playerAnswer = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();

    int selectedIndex = playerAnswer.Length == 1 ? letters.IndexOf(playerAnswer[0]) : -1;

    for (int i = 0; i < 3; i++)
    {
        await Task.Delay(1000);
        Console.Write(".");
    }

    Console.WriteLine();

    if (selectedIndex >= 0 && answers[selectedIndex] == correctAnswer)
    {
        Console.WriteLine("Correct! Advancing to next question...");
        score++;
        for (int i = 0; i < 3; i++)
        {
            await Task.Delay(3000);
            Console.Write(".");
            Console.Clear();
        }
        await QuestionTwo(score);
    }
    else if (selectedIndex >= 0 && answers[selectedIndex] == fOneHistory)
    {
        Console.WriteLine(
            "While not making MotoGP history, he still made history this year as he became the youngest WDC winner in F1 at just 20y and 68d old, taking the title of youngest WDC winner from Sebastian Vettel at 23y and 133d old"
        );
        for (int i = 0; i < 3; i++)
        {
            await Task.Delay(5000);
            Console.Write(".");
            Console.Clear();
        }
        await QuestionTwo(score);
    }
    else
    {
        Console.WriteLine("Incorrect... advancing to next question...");
        for (int i = 0; i < 3; i++)
        {
            await Task.Delay(3000);
            Console.Write(".");
            Console.Clear();
        }
        await QuestionTwo(score);
    }
}

static async Task QuestionTwo(int score)
{
    Random random = new Random();
    Console.WriteLine(
        "Making their debut with Minardi back in 2001, this F1 driver retired from Formula 1 in 2018 just to later come back in 2021. Securing 2 WDC in F1, 1 world title in WEC and 2 wins at the 24 Hour of Le Mans.. Who are they? "
    );

    string correctAnswer = "Fernando Alonso";
    string iceMan = "Kimi Räikkönen";

    string[] answers = { "Fernando Alonso", "Kimi Räikkönen", "Mark Webber", "Juan Pablo Mantoya" };

    for (int i = answers.Length - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);

        string temporary = answers[i];
        answers[i] = answers[j];
        answers[j] = temporary;
    }

    string letters = "ABCD";

    for (int i = 0; i < answers.Length; i++)
    {
        Console.WriteLine($"{letters[i]}. {answers[i]}");
    }

    string playerAnswer = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();

    int selectedIndex = playerAnswer.Length == 1 ? letters.IndexOf(playerAnswer[0]) : -1;

    for (int i = 0; i < 3; i++)
    {
        await Task.Delay(1000);
        Console.Write(".");
    }

    Console.WriteLine();

    if (selectedIndex >= 0 && answers[selectedIndex] == correctAnswer)
    {
        Console.WriteLine("Correct! Advancing to next question...");
        score++;
        for (int i = 0; i < 3; i++)
        {
            await Task.Delay(3000);
            Console.Write(".");
            Console.Clear();
        }
        await QuestionThree(score);
    }
    else if (selectedIndex >= 0 && answers[selectedIndex] == iceMan)
    {
        Console.WriteLine(
            "Bwoah, that's incorrect... The Iceman is visibly dissapointed.. and that's rare..."
        );
        for (int i = 0; i < 3; i++)
        {
            await Task.Delay(3000);
            Console.Write(".");
            Console.Clear();
        }
        await QuestionThree(score);
    }
    else
    {
        Console.WriteLine("Incorrect... advancing to next question...");
        for (int i = 0; i < 3; i++)
        {
            await Task.Delay(3000);
            Console.Write(".");
            Console.Clear();
        }
        await QuestionThree(score);
    }
}

static async Task QuestionThree(int score)
{
    Random random = new Random();
    Console.WriteLine(
        "Romain Grosjean was given the nickname 'The Phoenix' after escaping from his fiery crash at this 2020 Grand Prix, which circuit was it?"
    );

    string correctAnswer = "Bahrain International Circuit";

    string[] answers =
    {
        "Bahrain International Circuit",
        "Romain Grosjean International Circuit (named to honor him after the crash)",
        "Circuit de Spa-Francorchamps ",
        "Monte Carlo street circuit",
    };

    for (int i = answers.Length - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);

        string temporary = answers[i];
        answers[i] = answers[j];
        answers[j] = temporary;
    }

    string letters = "ABCD";

    for (int i = 0; i < answers.Length; i++)
    {
        Console.WriteLine($"{letters[i]}. {answers[i]}");
    }

    string playerAnswer = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();

    int selectedIndex = playerAnswer.Length == 1 ? letters.IndexOf(playerAnswer[0]) : -1;

    for (int i = 0; i < 3; i++)
    {
        await Task.Delay(1000);
        Console.Write(".");
    }

    Console.WriteLine();

    if (selectedIndex >= 0 && answers[selectedIndex] == correctAnswer)
    {
        Console.WriteLine("Correct! Advancing to next question...");
        score++;
        for (int i = 0; i < 3; i++)
        {
            await Task.Delay(3000);
            Console.Write(".");
            Console.Clear();
        }
        await QuestionFour(score);
    }
    else
    {
        Console.WriteLine("Incorrect... advancing to next question...");
        for (int i = 0; i < 3; i++)
        {
            await Task.Delay(3000);
            Console.Write(".");
            Console.Clear();
        }
        await QuestionFour(score);
    }
}
static async Task QuestionFour(int score)
{
    Random random = new Random();
    Console.WriteLine(
        "On September 23rd, 2024 this F1 Driver nicknamed 'The Honey Badger' left the F1 Paddock of the Singapore GP for the final time. Who was this?"
    );

    string correctAnswer = "Daniel Joseph Ricciardo";

    string[] answers =
    {
        "Daniel Joseph Ricciardo",
        "Carlos Sainz Vázquez de Castro Cenamor Rincón Rebollo Virto Moreno de Aranda Don Per Urrielagoiria Pérez del Pulgar",
        " Charles Marc Hervé Perceval Leclerc",
        "Oscar Jack Piastri",
    };

    for (int i = answers.Length - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);

        string temporary = answers[i];
        answers[i] = answers[j];
        answers[j] = temporary;
    }

    string letters = "ABCD";

    for (int i = 0; i < answers.Length; i++)
    {
        Console.WriteLine($"{letters[i]}. {answers[i]}");
    }

    string playerAnswer = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();

    int selectedIndex = playerAnswer.Length == 1 ? letters.IndexOf(playerAnswer[0]) : -1;

    for (int i = 0; i < 3; i++)
    {
        await Task.Delay(1000);
        Console.Write(".");
    }

    Console.WriteLine();

    if (selectedIndex >= 0 && answers[selectedIndex] == correctAnswer)
    {
        Console.WriteLine(
            "This still makes me sad everytime I hear it.. but you're right.. and he's never going to come back..."
        );
        score++;
        for (int i = 0; i < 3; i++)
        {
            await Task.Delay(3000);
            Console.Write(".");
            Console.Clear();
        }
        FinalResult(score);
    }
    else
    {
        Console.WriteLine("Incorrect.. DRS </3");
        for (int i = 0; i < 3; i++)
        {
            await Task.Delay(3000);
            Console.Write(".");
            Console.Clear();
        }
        FinalResult(score);
    }
}
static void FinalResult(int score)
{
    Console.WriteLine("Congratualtions! You have finished this part of the trivia!");
    if (score == 4)
    {
        Console.WriteLine(
            $"{score} for {score}! 100%! You either really know your stuff.. or you're really good at guessing... Keep it up in the next 2 sections!"
        );
    }
    else if (score == 3)
    {
        Console.WriteLine(
            $"{score} of 4.. 75% for this section is really good! Hopefully the next sections you get 100%!"
        );
    }
    else if (score == 2)
    {
        Console.WriteLine(
            $"{score} of 4.. as a fan of motorsport and F1 especially, I'm sad to see that, but 50% isn't the worst! Hopefully the next sections go better for you!"
        );
    }
    else if (score == 1)
    {
        Console.WriteLine(
            $"{score} of 4.. Either motorsport isn't your strongsuit, or you guessed because you couldn't care less, which honestly I don't blame you. Hopefully the next section is easier for you.."
        );
    }
    else
    {
        Console.WriteLine($"{score} of 4.. Hopefully the other sections go better for you..");
    }
}
