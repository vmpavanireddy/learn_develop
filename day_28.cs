using System;

interface IPlayable
{
    void Play();
}

class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Playing the guitar.");
    }
}

class day_28
{
    public static void Main(string[] args)
    {
        IPlayable instrument = new Guitar();
        instrument.Play();
    }
}