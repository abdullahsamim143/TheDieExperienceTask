using System;

namespace TheDieExperienceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Craps game = new Craps();
                Console.WriteLine("Game Starting... \n");
                game.Play();
                Console.WriteLine("\n Enter to play agian");
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
