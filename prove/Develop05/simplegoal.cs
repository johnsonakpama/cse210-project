using System;

using System. Collection.Geneeric;
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(Sstring name, int point) : base[name, point]
        {}

        public override void RecordEvent()
        {
            Console.WriteLine($"Complete goal: {name} {+{points}}");
        }
        public override string GetStatus()
        {
            return "[]" + name
        }
    }
}