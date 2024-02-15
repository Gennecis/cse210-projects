public class SimpleGoal : Goal
{
    public override void RecordEvent()
    {
        _isCompleted = true;
    }

    public override string Progress()
    {
        return _isCompleted ? "[X] Completed" : "[ ] Incomplete";
    }
}
