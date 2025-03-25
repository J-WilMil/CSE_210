using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Stack<List<Word>> _hiddenHistory;  // Stack to store last hidden words
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _hiddenHistory = new Stack<List<Word>>();
    }

    public void HideRandomWords(int numberToHide)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0) return;

        var hiddenWords = new List<Word>();
        foreach (var word in visibleWords.OrderBy(_ => _random.Next()).Take(numberToHide))
        {
            word.Hide();
            hiddenWords.Add(word);
        }
        _hiddenHistory.Push(hiddenWords);
    }

    public void UndoLastHide()
    {
        if (_hiddenHistory.Count > 0)
        {
            foreach (var word in _hiddenHistory.Pop())
            {
                word.Show();
            }
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
