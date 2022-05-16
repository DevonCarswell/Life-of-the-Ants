using System;

namespace Codecool.LifeOfAnts;

public class Drone : Ant
{
    public Drone(Position pos) : base(pos)
    {

    }

    public override void Act(int size)
    {
        if (position.X < size / 2)
        {
            position = new Position(position.X + 1, position.Y);
        }else if (position.X > size / 2)
        {
            position = new Position(position.X - 1, position.Y);
        }

        if (position.Y < size / 2)
        {
            position = new Position(position.X, position.Y+1);
        }else if (position.Y > size / 2)
        {
            position = new Position(position.X, position.Y-1);
        }
        else
        {
            return;
        }
    }

    public void Talk()
    {
        throw new NotImplementedException();
    }
}