using System;
using System.Collections;

class MyClass : IEnumerator, IEnumerable
{
    char[] chrs = { 'A', 'B', 'C', 'D' };
    int index = -1;

    // Implement IEnumerable. 
    public IEnumerator GetEnumerator()
    {
        return this;
    }

    // The following methods implement IEnumerator. 

    // Return the current object. 
    public object Current
    {
        get
        {
            return chrs[index];
        }
    }

    // Advance to the next object.  
    public bool MoveNext()
    {
        if (index == chrs.Length - 1)
        {
            Reset(); // reset enumerator at the end. 
            return false;
        }

        index++;
        return true;
    }

    // Reset the enumerator to the start. 
    public void Reset()
    {
        index = -1;
    }
}

