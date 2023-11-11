using System;

class Rrference
{
private string _referenceString; 

public Reference(string book, string chapter, string verse)
{
    _referencestring = $"{book} {chapter}:{verse}";
}
public Reference(string book, string chapter, string verse, string endverse)

{
    _referencestring = $"{book} {chapter}:{verse}-{endverse}";

}

public string GetReferenceString()
{
    return _referenceString;
}

}