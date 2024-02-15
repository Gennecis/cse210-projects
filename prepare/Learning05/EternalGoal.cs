public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        // Always increments value
        _value += 100;
    }

    public override string Progress()
    {
        return $"Progress: {_value} points";
    }
}
