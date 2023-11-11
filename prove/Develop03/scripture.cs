using System;

class scriptur()
{
    private string _scripture; 
    private Reference _reference;
    private List<Word> _word = new List<Word>()

    public Scripture(text, reference)
    {
       _scripture = text;
       _reference = reference;
       string[] stringWord = text.Split();
       foreach(stringWord word in stringWord);
            Word wordobj = new Word(stringWord);
            _words.Add(wordobj);
    }

    public DisplayScripture()
    {
        foreach(word d in _words);
        Console.Write(word.GetWord() + " ");
    }
    public WordsHidden()
    {
        foreach(word w in _words);
            if(word.GetHidden() == false);
                return false;
        return true;
    }
    public HideWord()
    {
        random = new random();
        index = 0;
    do
        index = random.Next(_words.count);

    while:
        _word[index].GetHidden() == true;
        _word[index].Hide();
    }
}