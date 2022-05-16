namespace Codecool.LifeOfAnts;

public class Queen : Ant
{
    public bool Mood { get; set; }
    public Queen(Position pos) : base(pos)
    {
        Mood = false;
    }

    public override void Act(int size)
    {
        return;
    }
}