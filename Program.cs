do{
Console.WriteLine("What is the capital of Texas? (type the number)");
Console.WriteLine("1. Washington");
Console.WriteLine("2. Moscow");
Console.WriteLine("3. Austin");
Console.WriteLine("4. Verity");
}while (Q1());

do{
Console.WriteLine("Who was the first to land on the moon? (type the number)");
Console.WriteLine("1. Niel Armstrong");
Console.WriteLine("2. Verity");
Console.WriteLine("3. Buzz Aldrin");
Console.WriteLine("4. Yuri Gagarin");
}while (Q2());

do{
Console.WriteLine("What does Hank Hill from King of the Hill");
Console.WriteLine("love the most? (type the number)");
Console.WriteLine("1. Beer");
Console.WriteLine("2. Propane");
Console.WriteLine("3. Grilling");
Console.WriteLine("4. All Of The Above");
}while (Q3());

do{
Console.WriteLine("Who was the first president of the U.S.");
Console.WriteLine("1. Abraham Lincoln");
Console.WriteLine("2. George Washington");
Console.WriteLine("3. Teddy Roosevelt");
Console.WriteLine("4. Verity");
}while (Q4());


bool Q1 ()
{
    int answer1 = int.Parse(Console.ReadLine());
    bool wrong = answer1 != 3;//<- this determines the wrong/right answer
    if (wrong == true)
    {   
        Console.WriteLine(" ");
        Console.WriteLine("FALSE, answer again");
        Console.WriteLine(" ");
        return wrong;
    }
    else if (answer1 > 4 || answer1 < 1)
    {
        Console.WriteLine(" ");
        Console.WriteLine("CHOOSE A REAL OPTION!");
        Console.WriteLine(" ");
        return wrong;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Correct, continue to the next question");
        Console.WriteLine(" ");
        return wrong;
    }
}

bool Q2 ()
{
    int answer2 = int.Parse(Console.ReadLine());
    bool wrong = answer2 != 1;//<- this determines the wrong/right answer
    if (wrong == true)
    {   
        Console.WriteLine(" ");
        Console.WriteLine("FALSE, answer again");
        Console.WriteLine(" ");
        return wrong;
    }
    else if (answer2 > 4 || answer2 < 1)
    {
        Console.WriteLine(" ");
        Console.WriteLine("CHOOSE A REAL OPTION!");
        Console.WriteLine(" ");
        return wrong;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Correct, continue to the next question");
        Console.WriteLine(" ");
        return wrong;
    }
}

bool Q3 ()
{
    int answer2 = int.Parse(Console.ReadLine());
    bool wrong = answer2 != 4;//<- this determines the wrong/right answer
    if (wrong == true)
    {   
        Console.WriteLine(" ");
        Console.WriteLine("Yes, he does love that, but what else?");
        Console.WriteLine(" ");
        return wrong;
    }
    else if (answer2 > 4 || answer2 < 1)
    {
        Console.WriteLine(" ");
        Console.WriteLine("CHOOSE A REAL OPTION!");
        Console.WriteLine(" ");
        return wrong;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Correct, continue to the next question");
        Console.WriteLine(" ");
        return wrong;
    }
}

bool Q4 ()
{
    int answer4 = int.Parse(Console.ReadLine());
    bool wrong = answer4 != 2;//<- this determines the wrong/right answer
    if(answer4 == 4)
    {
        Console.WriteLine(" ");
        Console.WriteLine("ಠ_ಠ ...");
        Console.WriteLine("ب_ب ...");
        Console.WriteLine("(╬ಠ益ಠ) GRRRR HRRR");
        Console.WriteLine("(ノಠ益ಠノ) HHRRRRR RR");
        Console.WriteLine("୧༼ಠ益ಠ༽୨ RAAAAAAAAAAAH!");
        Console.WriteLine("ALRIGHT THAT'S IT!");
        Console.WriteLine("IF YOU LOVE VERITY SO MUCH");
        Console.WriteLine("THEN YOU CAN MEET HIM NOW!");
        Console.WriteLine("HE WILL BE ON YOUR DOORSTEP IN 3 SECONDS");
        Console.WriteLine("I HOPE YOU'RE HAPPY!");
        Console.WriteLine(" ");
        return wrong;
    }
    else if(wrong == true)
    {   
        Console.WriteLine(" ");
        Console.WriteLine("Yes, he does love that, but what else?");
        Console.WriteLine(" ");
        return wrong;
    }
    else if (answer4 > 4 || answer4 < 1)
    {
        Console.WriteLine(" ");
        Console.WriteLine("CHOOSE A REAL OPTION!");
        Console.WriteLine(" ");
        return wrong;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Correct, continue to the next question");
        Console.WriteLine(" ");
        return wrong;
    }
}

