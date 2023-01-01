using System;

namespace GOF.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
           // uncomment one of the two below lines ( act as dependency injection based on configuration)
           // MazeGame mazeGame = new MazeGame(new MazeFactory());
          //   MazeGame mazeGame = new MazeGame(new MagicMazeFactory());

        }
    }
}
