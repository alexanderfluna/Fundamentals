using System;
using System.Collections;

class LetterEnumerator : IEnumerator
{
    string[] letters;
    int Position = -1;

    public LetterEnumerator(string[] theletters)
    {
        Console.Write("Constructing LetterEnumerator: ");
        letters = new string[theletters.Length];
        for (int i = 0; i < theletters.Length; i++) {
           letters[i] = theletters[i];        
           Console.Write(" "+ letters[i]);
        }
        Console.WriteLine("\n");
    }

    public object Current
    {
        get { return letters[Position]; }
    }

    public bool MoveNext()
    {
        Console.Write("MoveNext: ");
        if (Position < letters.Length - 1)
        {
            Position++;
            Console.WriteLine("Position is {0}; the letter is {1}", Position, letters[Position]);
            return true;
        }
        else
        {
            Console.WriteLine("Reached the end");
            return false;
        }
    }

    public void Reset()
    {
        Position = -1;
        Console.WriteLine("resetting position to -1");
    }
}

class LetterList : IEnumerable
{
    string[] letters = { "A", "B", "C" };
    public IEnumerator GetEnumerator()
    {
        return new LetterEnumerator(letters);
    }
}

class MainClass
{
    static void Main()
    {
        LetterList mc = new LetterList();

        foreach (string s in mc)
            Console.WriteLine("foreach loop: s is {0} ", s);

    }
}