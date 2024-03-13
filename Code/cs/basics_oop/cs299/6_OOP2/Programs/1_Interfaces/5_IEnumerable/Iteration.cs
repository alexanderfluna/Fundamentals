using System;
//using System.Collections.Generic;
using System.Collections;

namespace EnablingIteration {

    public class MyContainer : IEnumerable {
        
        private ArrayList myPossessions = new ArrayList();

        public void Add(String item) {
            myPossessions.Add(item);
        }

        // Iterator enabling foreach loop with yield return
        // without making an IEnumerator.
        // When a yield return statement is reached in the iterator 
        // method, expression is returned, and the current location 
        // in code is retained. Execution is restarted from that 
        // location the next time that the iterator function is 
        // called. You can use a yield break statement to end the 
        // iteration.
        //
        public IEnumerator GetEnumerator() {
            for (int index = 0; index < myPossessions.Count; index++) {
                yield return myPossessions[index];
            }
        }

        // Code to satisfy requirement that MyContainer 
        // inherits from IEnumerable
        // Explicit interface member implementation
        IEnumerator IEnumerable.GetEnumerator() {
            return null;
        }
    }

    
}
