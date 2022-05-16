using System;

namespace Codecool.LifeOfAnts
{
    /// <summary>
    ///     Simulation main class
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     Main method
        /// </summary>
        public static void Main()
        {
            Colony colony = new Colony(11);
            colony.GenerateAnts(0,0,4);
            while (true)
            {
                Console.Clear();
                colony.Display();
                Console.ReadLine();
                colony.Update();
            }
            
        }
    }
}
