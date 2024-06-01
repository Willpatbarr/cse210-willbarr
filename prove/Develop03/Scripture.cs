using System;

public class Scripture
{
    private List<Word> _text;
    private Reference _reference;
    private int _hiddenWordCount;

    public Scripture(List<Word> text, Reference reference)
    {
        _text = text;
        _reference = reference;
        _hiddenWordCount = 0; // total words hidden in the scripture
    }
    
    public void HideWords()
    {
        Random random = new Random(); 
        int wordsToHide = 3;
        int wordsHidden = 0; // words hidden by this loop this iteration

        while (wordsHidden < wordsToHide)
        {
            int index = random.Next(_text.Count);
            if (!_text[index].IsHidden())
            {
                _text[index].MakeWordBlank();
                _hiddenWordCount++; // increments the counter of how many words have been hidden
                wordsHidden++; // increments how many times the loop needs to run for
            }
        }
    }
    public string GetRenderedText()
   {
         string renderedText = $"{_reference.GenerateReference()}\n";
        foreach (var word in _text)
        {
            renderedText += word.GetText() + " ";
        }
        return renderedText.Trim();
    }
    public bool IsCompletelyHidden()
    {
        int totalWords = _text.Count; //initializes a variable to count total words in the text

        if (totalWords == _hiddenWordCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}