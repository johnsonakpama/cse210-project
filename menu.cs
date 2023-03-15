using System;

public class menuOption
{
    private string _createNewGoals;
    private string _listGoals;
    private string _saveGoals;
    private string _loadGoals;
    private string _recordEvent;
    private string _Quit;

    public menuOption(string createNewGoals, string listGoals, string saveGoals, string loadGoals, string recordEvent, string Quit)
    {
        _createNewGoals = createNewGoals;
        _listGoals = listGoals;
        _saveGoals = saveGoals;
        _loadGoals = loadGoals;
        _recordEvent = recordEvent;
        _Quit = Quit;
    }
    public string createNewGoals()
    {
        return _createNewGoals;
    }
    public string listGoals()
    {
        return _listGoals;
    }
    public string saveGoals()
    {
        return _saveGoals;
    }
    public string loadGoals()
    {
        return _loadGoals;
    }
    public string recordEvent()
    {
        return _recordEvent;
    }
    public string Quit()
    {
        return _Quit;
    }
    public string GetSummary()
    {
        return _createNewGoals + "_" + _listGoals + "-"+ _saveGoals + "-" + _loadGoals + "-" + _recordEvent + "-" + _Quit;
    }
}