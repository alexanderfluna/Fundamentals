using System;
using System.Collections;

namespace Composite
{

    // A sequence containing a single integer
    public class IntSingular : IntSequence {
        private int it; // the single integer in the sequence 

        public IntSingular(int it) {
            this.it = it;
        }

        // the min of the sequence is the single integer
        public override int? Min  {
            get { 
                return it; 
            }
        }

        // the max of the sequence is the single integer
        public override int? Max  {
            get { 
                return it; 
            }
        }

        // need to be able to iterate through any IntSequence
        public override IEnumerator GetEnumerator()  {
            return new SingularEnumerator(this);
        }

        // need to be able to iterate through any IntSequence
        private class SingularEnumerator : IEnumerator  {

            private readonly IntSingular ints;
            private int idx;

            public SingularEnumerator(IntSingular ints) {
                this.ints = ints;
                idx = -1;   // initialy position enumerator outside range
            }

            public Object Current  {
                get { return ints.it; }
            }

            // can only move to next from outside the range
            public bool MoveNext() {
                if (idx == -1) { 
                    idx++;
                    return true; 
                }
                else
                    return false; 
        }

            public void Reset() {
                idx = -1;
            }
        }
    }
}