using System;

namespace Overriding {

    public class BaseClass {

        // Fields
        protected int baseClassValue;

        // Constructor
        public BaseClass(int value) {
            baseClassValue = value;
        }

        public BaseClass() {
            baseClassValue = 0;
        }

        // Commands
        public virtual void SomeImportantOperation() {
            baseClassValue += 500;
        }

        // Queries
        public override string ToString() {
            return "baseClassValue: " + baseClassValue;
        }
    }
}
