using System;

namespace Overriding {

    public class GrandChildClass : ChildClass {

        // Constructor
        public GrandChildClass(int value) : base(value) {
        }

        public GrandChildClass() : base() {
        }

        // Commands
        public override void SomeImportantOperation() {
            baseClassValue /= 2;
        }
    }
}

