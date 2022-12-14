using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Codecool.LifeOfAnts;

public class Colony
{
    public int[,] AntColony { get;}
    private List<Ant> _ants = new List<Ant>();
    public int _width;
    public int Counter { get; set; }
    public Colony(int width)
    {
        AntColony = new int[width, width];
        _width = width;
        Queen queen = new Queen(new Position(width / 2, width / 2));
        _ants.Add(queen);
        Counter = new Random().Next(50, 101);
}

    public void GenerateAnts(int droneNum, int workerNum, int soldierNum)
    {
        for (int i = 0; i < droneNum; i++)
        {
            Tuple<int, int> position = StarterPosition();
            Drone drone = new Drone(new Position(position.Item1, position.Item2));
            _ants.Add(drone);
        }
        for (int i = 0; i < workerNum; i++)
        {
            Tuple<int, int> position = StarterPosition();
            Worker worker = new Worker(new Position(position.Item1, position.Item2));
            _ants.Add(worker);
        }  

        for (int i = 0; i < soldierNum; i++)
        {
            Tuple<int, int> position = StarterPosition();
            Soldier soldier = new Soldier(new Position(position.Item1, position.Item2));
            _ants.Add(soldier);
        }
    }

    public Tuple<int, int> StarterPosition()
    {
        Random r = new Random();

        while (true)
        {
            int row = r.Next(0, _width);
            int col = r.Next(0, _width);

            if (row != _width / 2 && col != _width / 2)
            {
                return new Tuple<int, int>(row, col);
            }

        }
        


    }
    public void Display()
    {
        for (int row = 0; row < _width; row++)
        {
            for (int col = 0; col < _width; col++)
            {
                switch (GetAnt(row,col))
                {
                    case "Codecool.LifeOfAnts.Queen":
                          Console.Write('Q');
                          break; 
                    case "Codecool.LifeOfAnts.Worker":
                          Console.Write('W');
                          break; 
                    case "Codecool.LifeOfAnts.Soldier":
                          Console.Write('S');
                          break; 
                    case "Codecool.LifeOfAnts.Drone":
                          Console.Write('D');
                          break;
                    case ".":
                        Console.Write('.');
                        break;
                }
            }

            Console.WriteLine();
        }

    }

    public string GetAnt(int row, int col)
    {
        foreach (var ant in _ants)
        {
            if (ant.position.X == row && ant.position.Y == col)
            {
                return ant.GetType().ToString();
            }
        }

        return ".";
    }

    public void Update()
    {

        foreach (Ant ant in _ants)
        {
            ant.Act(_width);
            Counter--;

            if (Counter <= 0 && ant is Queen)
            {
                Queen queen = (Queen)ant;
                queen.Mood = true;
            }
        }
    }
}
    
