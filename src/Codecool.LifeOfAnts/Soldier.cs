using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.LifeOfAnts
{
    public class Soldier : Ant
    {
        private int _steps = 0;
        public Soldier(Position pos) : base(pos)
        {

        }

        public override void Act(int size)
        {
            
            switch (_steps)
            {
                case 0:
                    if (position.X > 0 && (position.X - 1 != size / 2 || position.Y != size / 2))
                    {
                        position = new Position(position.X - 1, position.Y);
                    }
                    _steps++;
                    break;
                case 1:
                    if (position.Y < size - 1 && (position.X != size / 2 || position.Y + 1 != size / 2))
                    {
                        position = new Position(position.X, position.Y + 1);
                    }
                    _steps++;
                    break;
                case 2:
                    if (position.X < size - 1 && (position.X + 1 != size / 2 || position.Y != size / 2))
                    {
                        position = new Position(position.X + 1, position.Y);
                    }
                    _steps++;
                    break;
                case 3:
                    if (position.Y > 0 && (position.X != size / 2 || position.Y - 1 != size / 2))
                    {
                        position = new Position(position.X, position.Y - 1);
                    }
                    _steps = 0;
                    break;
            }
            

        }
    }
}
