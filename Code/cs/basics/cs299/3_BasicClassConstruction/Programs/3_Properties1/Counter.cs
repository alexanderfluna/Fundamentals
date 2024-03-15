#region Using directives

using System;
using System.Text;

#endregion

namespace IntroducingProperties {

    public class Counter {
        
        // Instance Variable
        private int countValue;

        // Read-only property
        public int CountValue { // Read-only property
            get {
                return countValue;
            }
        }

        // Methods
        public void Increment() {
            countValue++;
        }

        public void Reset() {
            countValue = 0;
        }
    }
}
