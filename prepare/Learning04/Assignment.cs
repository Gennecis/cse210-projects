using System;
public class Assignment
{
private string _studentName;
private string _topic;

public Assignment(string student, string topic)
{
    _studentName = student;
    _topic = topic;
}

public string GetstudentName()
{
    return _studentName;
}

public string Gettopic()
{
    return _topic;
}
public string Getsummary()
{
    return $"{_studentName} - {_topic}";
}

}