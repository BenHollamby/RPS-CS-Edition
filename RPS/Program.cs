// See https://aka.ms/new-console-template for more information
Random rps = new Random();
//Console.WriteLine(rps.Next(0, 3));

int games = 0;
int ties = 0;
int computer1Wins = 0;
int computer2Wins = 0;
int computer1Losses = 0;
int computer2Losses = 0;


while (games < 100000000)
{
    games++;
    int computer1Choice = rps.Next(0, 3);
    int computer2Choice = rps.Next(0, 3);

    if (computer1Choice == computer2Choice)
    {
        //Console.WriteLine("Tie");
        ties++;
    }

    else if (computer1Choice == 0 && computer2Choice == 2 || computer1Choice == 1 && computer2Choice == 0 || computer1Choice == 2 && computer2Choice == 1)
    {
        //Console.WriteLine("Computer One Wins");
        computer1Wins++;
        computer2Losses++;
    }

    else if (computer1Choice == 2 && computer2Choice == 0 || computer1Choice == 1 && computer2Choice == 2 || computer1Choice == 0 && computer2Choice == 1)
    {
        //Console.WriteLine("Computer Two Wins");
        computer2Wins++;
        computer1Losses++;
    }
}

Console.WriteLine("Number of games: " + games);
Console.WriteLine("Number of ties : " + ties);
Console.WriteLine("Computer 1 Wins :" + computer1Wins);
Console.WriteLine("Computer 1 Losses :" + computer1Losses);
Console.WriteLine("Computer 2 Wins :" + computer2Wins);
Console.WriteLine("Computer 2 Losses :" + computer2Losses);



if (computer1Wins == computer2Wins)
{
    Console.WriteLine("Computers TIE");
}

else if (computer1Wins > computer2Wins)
{
    Console.WriteLine("Computer One won this round and won by " + (computer1Wins - computer2Wins) + " matches");

}

else if (computer1Wins < computer2Wins)
{
    Console.WriteLine("Computer Two won this round and won by " + (computer2Wins - computer1Wins) + " matches");
}

