public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private readonly int _targetTimes;

    public ChecklistGoal(int targetTimes)
    {
        _targetTimes = targetTimes;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        _value += 50; // Points for each completion
        if (_timesCompleted == _targetTimes)
        {
            _value += 500; // Bonus points when the goal is completed
            _isCompleted = true;
        }
    }

    public override string Progress()
    {
        return $"Completed {_timesCompleted}/{_targetTimes} times";
    }
}
