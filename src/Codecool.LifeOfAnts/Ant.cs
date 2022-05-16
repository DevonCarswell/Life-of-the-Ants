using System;

namespace Codecool.LifeOfAnts;

public abstract class Ant
{
    public Position position { get; set; }
    
    public Ant(Position pos)
    {
        position = pos;

    }

    public abstract void Act(int size);

}