using System;

        // create class entry
        // _entry : string / _dateTime : int
        // SaveEntryToJournal() : void / StartEntry() : void

public class Entry
{
    public string Prompt;
    public string Response;
    public string Date;

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = the CurrentTime.ToShortDateString();
    }

    public override string ToString()
}