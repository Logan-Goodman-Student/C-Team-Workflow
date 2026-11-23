await QuestionOne();
static async Task QuestionOne()
{
Random random = new Random();

Console.WriteLine("Welcome to our Trivia game! We will ask you 12 questions of completely unrelated topics.. how many can you get?");
Console.WriteLine("================================================================================================================");

Console.WriteLine("Question 1: Who won their 8th World Championship Title in MotoGP this weekend, making history?");


string correctAnswer = "Marc Marquez";

string[] answers =
{
    "Marc Marquez",
    "Kimi Antonelli",
    "Valentino Rossi",
    "Scottie Scheffler"
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


int selectedIndex = playerAnswer.Length == 1
    ? letters.IndexOf(playerAnswer[0])
    : -1;

for (int i = 0; i < 3; i++)
{
    await Task.Delay(1000);
    Console.Write(".");
}

Console.WriteLine(); 

if (selectedIndex >= 0 && answers[selectedIndex] == correctAnswer)
{
    Console.WriteLine("Correct! Advancing to next question...");
}
else
{
    Console.WriteLine("Incorrect... advancing to next question...");
}
}