using System;

class Word
{ 
   private string _word;
   private string _hiddenWord;
   private bool _hidden;

public word(string word)
{
    _word = word;
    _hidden = false;
    _hiddenWord = "";
    foreach (char letter in _word)
    {
        _hiddenWord += ' -';
    }
}

public bool GetHidden()
{
    return _hidden;
}

public void Hide()
{
    _hidden = true;
}

public string GetWord()
{
    if(_hidden == true)
    {
        return _hiddenWord;
    }
    else
    {
        return _word;
    }
}

}