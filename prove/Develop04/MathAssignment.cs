public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    // Notice the syntax here that the MathAssignment constructor has 4 parameter and their
    //it passes 2 of them dirctly to the aaaaaaaaaaaaa "base" constructor which is the "Assignment"
    // class constructor

    public MathAssignment(string studentName,string topic, string _textbookSection,string problem)
    : base (studentName,topic)
    {
        // Here we set the MathAsignment specific variable
        _textbookSection = textbookSection;
        _problem = problem;
    }
    public string GetHomeworkList()
    {
        return $"section{_textbookSection}problem{_problem}";
    }
}
