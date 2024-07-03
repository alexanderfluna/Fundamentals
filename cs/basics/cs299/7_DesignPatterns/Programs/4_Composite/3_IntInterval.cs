using System;
using System.Collections;

namespace Composite
{
    // A sequence of integers within an interval
    public class IntInterval : IntSequence {

        private int from, to;

        public IntInterval(int from, int to) {
            this.from = from;
            this.to = to;
        }

        // the min int in the interval
        public override int? Min {
            get {
                return Math.Min(from, to); 
            }
        }

        // the maxn int in the interval
        public override int? Max {
            get { 
                return Math.Max(from, to);             
            }
        }

        // need to be able to iterate through any IntSequence
        public override IEnumerator GetEnumerator() {
            return new IntervalEnumerator(this);
        }

        // need to be able to iterate through any IntSequence
        private class IntervalEnumerator : IEnumerator {

            private readonly IntInterval interval;
            private int idx;

            public IntervalEnumerator(IntInterval i) {
                this.interval = i;
                idx = -1;   // initialy position enumerator outside range
            }

            // from is not necessarili less than to
            public Object Current {
                get {
                    return (interval.from < interval.to) ?
                             interval.from + idx :
                             interval.from - idx;
                }
            }

            public bool MoveNext() {
                if (idx < Math.Abs(interval.to - interval.from)) { 
                    idx++; return true; 
                }
                else { 
                    return false; 
                }
            }

            public void Reset() {
                idx = -1;
            }
        }
    }
}