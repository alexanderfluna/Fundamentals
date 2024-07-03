using System;
using System.Collections;

namespace Composite
{

    public abstract class IntSequence
    {
        public abstract IEnumerator GetEnumerator();
        public abstract int? Min { get;}
        public abstract int? Max { get;}
    }
}