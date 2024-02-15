public abstract class Goal
{
    public string _name;
    public int _value;
    public bool _isCompleted;

    public string getName()
    {
        return _name;
    }

    public void setName(string name)
    {
        _name = name;
    }

    public int getValue()
    {
        return _value;
    }

    public void setValue(int value)
    {
        _value = value;
    }

    public bool getIsCompleted()
    {
        return _isCompleted;
    }

    public void setIsCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public abstract void RecordEvent();
    public abstract string Progress();
}
