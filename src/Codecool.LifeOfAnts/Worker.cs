using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.LifeOfAnts
{
    public class Worker : Ant
    {
        public Worker(Position pos) : base(pos)
        {

        }

        public override void Act(int size)
        {
            
            Random r = new Random();
            int enumLength = Enum.GetNames(typeof(Direction)).Length;
            Direction direction = (Direction) r.Next(enumLength);
            Console.WriteLine(direction);

            switch (direction)
            {
                case Direction.North:
                    if (position.X > 0 && (position.X -1 != size/2 || position.Y != size/2))
                    {
                        position = new Position(position.X - 1, position.Y);
                    }
                    break;
                case Direction.East:
                    if (position.Y > 0 && (position.X != size / 2 || position.Y + 1 != size / 2))
                    {
                        position = new Position(position.X, position.Y + 1);
                    }
                    break;
                case Direction.South:
                    if (position.X < size - 1 && (position.X + 1 != size / 2 || position.Y != size / 2))
                    {
                        position = new Position(position.X + 1, position.Y);
                    }
                    break;
                case Direction.West:
                    if (position.Y < size - 1 && (position.X != size / 2 || position.Y - 1 != size / 2))
                    {
                        position = new Position(position.X, position.Y - 1);
                    }
                    break;
            }
        }
    }
}
