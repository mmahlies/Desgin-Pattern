using System;

namespace GOF.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            MazeGame mazeGame = new MazeGame();
            MagicMazeGame magicMazeGame = new MagicMazeGame();
        }
    }
}
