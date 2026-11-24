await QuestionOne(0);

static void WaitForPlayer()
{
    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
    Console.Clear();
}

static async Task AnswerDelay()
{
    for (int i = 0; i < 3; i++)
    {
        await Task.Delay(1000);
        Console.Write(".");
    }

    Console.WriteLine();
}

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

    await AnswerDelay();

    if (selectedIndex >= 0 && answers[selectedIndex] == correctAnswer)
    {
        Console.WriteLine("Correct!");
        score++;
    }
    else if (selectedIndex >= 0 && answers[selectedIndex] == fOneHistory)
    {
        Console.WriteLine(
            "While not making MotoGP history, he still made history this year as he became the youngest WDC winner in F1 at just 20y and 68d old, taking the title of youngest WDC winner from Sebastian Vettel at 23y and 133d old"
        );
    }
    else
    {
        Console.WriteLine("Incorrect...");
    }

    WaitForPlayer();
    await QuestionTwo(score);
}

static async Task QuestionTwo(int score)
{
    Random random = new Random();

    Console.WriteLine(
        "Making their debut with Minardi back in 2001, this F1 driver retired from Formula 1 in 2018 just to later come back in 2021. Securing 2 WDC in F1, 1 world title in WEC and 2 wins at the 24 Hour of Le Mans.. Who are they?"
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

    await AnswerDelay();

    if (selectedIndex >= 0 && answers[selectedIndex] == correctAnswer)
    {
        Console.WriteLine("Correct!");
        score++;
    }
    else if (selectedIndex >= 0 && answers[selectedIndex] == iceMan)
    {
        Console.WriteLine(
            "Bwoah, that's incorrect... The Iceman is visibly disappointed.. and that's rare..."
        );
    }
    else
    {
        Console.WriteLine("Incorrect...");
    }

    WaitForPlayer();
    await QuestionThree(score);
}

static async Task QuestionThree(int score)
{
    Random random = new Random();

    Console.WriteLine(
        "Romain Grosjean was given the nickname 'The Phoenix' after escaping from his fiery crash at this 2020 Grand Prix, which circuit was it?"
    );

    string correctAnswer = "Bahrain International Circuit";
    string crashAtSuzuka = "Suzuka International Racing Course";
    string crashAtSpa = "Circuit de Spa-Francorchamps";
    string crashAtImola = "Autodromo Internazionale Enzo e Dino Ferrari";

    string[] answers =
    {
        "Bahrain International Circuit",
        "Suzuka International Racing Course",
        "Circuit de Spa-Francorchamps",
        "Autodromo Internazionale Enzo e Dino Ferrari",
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

    await AnswerDelay();

    if (selectedIndex >= 0 && answers[selectedIndex] == correctAnswer)
    {
        Console.WriteLine("Correct!");
        score++;
    }
    else if (selectedIndex >= 0 && answers[selectedIndex] == crashAtSuzuka)
    {
        Console.WriteLine(
            "Jules Bianchi crashed here in 2014. His car hydroplaned and he experienced a 254g head impact crash after running into the back of recovery tractor picking up the crashed car of Adrian Sutil. He passed away 9 months later due to his injuries."
        );
    }
    else if (selectedIndex >= 0 && answers[selectedIndex] == crashAtSpa)
    {
        Console.WriteLine(
            "Anthoine Hubert crashed here in Formula 2. Alesi spun out due to a tire puncture, and Hubert hit a car slowing down to avoid the incident, hitting the barrier and ending almost stationary on track. Correa came around the corner at high speed, and struck into the side of Hubert's #19 BWT Arden, causing Hubert's fatal injuries."
        );
    }
    else if (selectedIndex >= 0 && answers[selectedIndex] == crashAtImola)
    {
        Console.WriteLine(
            "This crash is most notable for the death of 3 time WDC winner Ayrton Senna during the 1994 Grand Prix on May 1st. However, this entire race weekend was a tragedy. During Friday's practice, Rubens Barrichello suffered a crash when he hit the wall and flipped his car. During Saturday's qualifying, Roland Ratzenberger suffered a fatal crash on what was only his 3rd F1 Grand Prix when his front wing broke off and got lodged under his car, causing a crash into a wall at 195.7 MPH."
        );
    }
    else
    {
        Console.WriteLine("Invalid answer. No point awarded.");
    }

    WaitForPlayer();
    await QuestionFour(score);
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

    await AnswerDelay();

    if (selectedIndex >= 0 && answers[selectedIndex] == correctAnswer)
    {
        Console.WriteLine(
            "This still makes me sad everytime I hear it.. but you're right.. and he's never going to come back..."
        );
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect.. DRS </3");
    }

    WaitForPlayer();
    FinalResult(score);
}

static void FinalResult(int score)
{
    if (score > 1)
    {
        Console.WriteLine("Congratulations! You have finished this part of the trivia!");
    }
    else
    {
        Console.WriteLine("Rough.. but hey at least this section is over now..");
    }
    if (score == 4)
    {
        Console.WriteLine(
            $"{score} for 4! 100%! You either really know your stuff.. or you're really good at guessing... Keep it up in the next 2 sections!"
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

    Console.WriteLine("\nPress Enter to finish...");
    Console.ReadLine();
}
