public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        -_topic = topic;
    }
    //Proving getter for our member variables

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + "_" + _topic
    }
}
