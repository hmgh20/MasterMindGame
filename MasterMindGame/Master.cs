using System;
using System.Runtime.CompilerServices;

public class MasterGame
{

    private string SecCode;
    private int maxtAttempt = 10;
    private int CurrentAttempts = 0;
    public MasterGame(string? code = null, int maxtAttempt = 10)
    {

        if (!string.IsNullOrEmpty(code))
            SecCode = code;
        else

            SecCode = TheSecCode();

        this.maxtAttempt = maxtAttempt;

    }

    private string TheSecCode()
    {
        Random num = new Random();
        string TheCode = "";

        for (int i = 0; i < 4; i++)
        {
            TheCode += num.Next(0, 9);
        }
        return TheCode;

    }

    public (int right, int wrong) ChecktheGuess(string guess)
    {
        int right = 0;
        int wrong = 0;
        bool[] secretMatched = new bool[4];
        bool[] guessMatched = new bool[4];


        for (int i = 0; i < 4; i++)
        {
            if (guess[i] == SecCode[i])
            {
                right++;
                secretMatched[i] = true;
                guessMatched[i] = true;

            }

        }

        for (int i = 0; i < 4; i++)
        {
            if (!guessMatched[i])
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!secretMatched[j] && guess[i] == SecCode[j])
                    {
                        wrong++;
                        secretMatched[j] = true;
                        break;
                    }
                }

            }

        }
        return (right, wrong);
    }

    public bool IsCorrectGuess(string guess)
    {
        return guess == SecCode;
    }

    public string GetSecretCode()
    {
        return SecCode;
    }
    public int GetMaxAttempt()
    {
        return maxtAttempt;
    }

    public int GetCurrentAttempts()
    {
        return CurrentAttempts;
    }

    public void IncrementAttempts()
    {
        CurrentAttempts++; 
    }

}