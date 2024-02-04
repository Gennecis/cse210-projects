using System;
public class mathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public mathAssignment(string student, string topic, string textbookSection, string problems) : base(student, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}