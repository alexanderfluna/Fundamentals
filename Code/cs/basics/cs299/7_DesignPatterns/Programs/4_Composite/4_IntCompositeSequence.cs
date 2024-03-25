using System;
using System.Collections;

namespace Composite
{
    // A collection of sequences, but also a sequence
    public class IntCompositeSequence : IntSequence {

        private const int SEQ_MAX = 10;
        private IntSequence[] componentSequences;
        private int componentPtr; // actually an index, 0 for an empty collection

        // Make a  new Composite from a single element
        public IntCompositeSequence(IntSequence c1)  {
            componentSequences = new IntSequence[SEQ_MAX];
            componentPtr = 0;
            componentSequences[componentPtr] = c1;
            componentPtr++;
        }

        // Make a  new Composite from a two elements
        public IntCompositeSequence(IntSequence c1, IntSequence c2)
        {
            componentSequences = new IntSequence[SEQ_MAX];
            componentPtr = 0;
            componentSequences[componentPtr] = c1;
            componentPtr++;
            componentSequences[componentPtr] = c2;
            componentPtr++;
        }

        // the minimum of the minimums of all copmonents
        public override int? Min    {
            get {
                int? res;
                if (componentPtr == 0) // collection is empty
                    return null;
                else {
                    res = componentSequences[0].Min;
                    for (int i = 1; i < componentPtr; i++)
                        if (componentSequences[i].Min < res)
                            res = componentSequences[i].Min;
                    return res;
                }
            }
        }

        // the maximum of the maximums of all copmonents
        public override int? Max {
            get {
                int? res;
                if (componentPtr == 0)
                    return null;
                else {
                    res = componentSequences[0].Max;
                    for (int i = 1; i < componentPtr; i++)
                        if (componentSequences[i].Max > res)
                            res = componentSequences[i].Max;
                    return res;
                }
            }
        }

        // need to be able to iterate through any IntSequence
        public override IEnumerator GetEnumerator() 
        {
            return new CompositeEnumerator(this);
        }

        // need to be able to iterate through any IntSequence
        private class CompositeEnumerator : IEnumerator {

            private readonly IntCompositeSequence comSeq;
            private IEnumerator idxEnumerator; 
            private int idx; //to index the array

            // will iterate over ics
            public CompositeEnumerator(IntCompositeSequence ics) {
                this.comSeq = ics;
                idx = -1;             // position index outside range
                idxEnumerator = null; // position enumerator outside range
            }

            public Object Current
            {
                get { return idxEnumerator.Current; }
            }

            // Move to the next int, single or within a sequence
            public bool MoveNext() {
                if (idx == -1 && comSeq.componentPtr > 0) {// At start position && Non-empty collection                {
                    idx++; // will work with the first sequence in the collection

                    // will go to any depth of composite, to construct an enumerator of non-composite sequence
                    idxEnumerator = comSeq.componentSequences[idx].GetEnumerator();
                    idxEnumerator.MoveNext(); // to the next element in the first non-composite sequence
                    return true;
                }
                else if (idx > -1 && idx < comSeq.componentPtr) { // Inside composite        
                    bool moveComp = idxEnumerator.MoveNext();
                    if (moveComp) //MoveNext of component succeeded
                        return moveComp;
                    else if (idx < comSeq.componentPtr - 1) { //Cannot MoveNext in the component,
                                                              // but this array not yet exhausted                   
                        idx++; // next in the array
                        // make an enumerator through the array[idx], go deep to a non-composite
                        idxEnumerator = comSeq.componentSequences[idx].GetEnumerator();
                        return this.MoveNext();
                    }
                    else // cannot increment idx. This collection is exhausted
                        return false;
                }
                else // cannot increment idx. This collection is exhausted
                    return false;
            }

            public void Reset()
            {
                idx = -1;
            }
        }
    }
}