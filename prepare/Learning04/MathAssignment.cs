public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    // Notice the syntax here that the mathAssignment constructor has 4 parameter and their
    // it passes 2 of then directlty to the "base" constructor which is the "Assignment" class constructor.

    public MathAssignment(string studentName,string topic,string textbookSection,string problem)
    : base (studentName, topic)
    {
        // Here we set the MathAssignment specific variables

        _textbookSection = textbookSection;
        _problem = problem;
    }
    public string GetHomeworkList()
    {
        return $"Sectrion{_textbookSection} problem{_problem}";
    }
}