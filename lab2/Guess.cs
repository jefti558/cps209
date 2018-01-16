using System;

public class Guess
{
    private int secret;

    public Guess()
    {
        var rand = new Random();
        secret = rand.Next(10);
    }

    public Guess(int secret)
    {
        this.secret = secret;
    }

    public string Check(int guess)
    {
        if (guess < secret) 
        {
            return "Too Low.";
        } else if (guess >= secret)
        {
            return "Too High.";
        }
        else
        {
            return "Correct!";
        }
    }

    public int GetSecret() 
    {
        return secret;
    }

    public void SetSecret(int newSecret)
    {
        secret = newSecret;
    }
}
