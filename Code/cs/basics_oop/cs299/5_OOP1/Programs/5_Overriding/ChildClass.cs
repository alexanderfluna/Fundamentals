using System;

namespace Overriding {

    public class ChildClass : BaseClass {

        // Constructor
        public ChildClass(int value) : base(value) {
        }

        public ChildClass() : base() {
        }

        // Commands
        public override void SomeImportantOperation() {
            baseClassValue *= 2;
        }
    }
}
