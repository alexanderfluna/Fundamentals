#region Using directives

using System;
using System.Text;

#endregion

namespace IntroducingProperties {

    public class SimplePropertiesApplication {

        // Instance variables
        private int importantValue1;
        private double importantValue2;
        private String importantValue3;

        // Constructor
        public SimplePropertiesApplication(int importantValue1) {
            this.importantValue1 = importantValue1;
        }

        // Properties
        public int ImportantValue1 { // Read-only property
            get {
                return importantValue1;
            }
        }

        public double ImportantValue2 { // Write-only property
            set {
                importantValue2 = value;
            }
        }

        public String ImportantValue3 { // Read-write property
            get {
                return importantValue3;
            }
            set {
                importantValue3 = value;
            }
        }

        // overriding Object.ToString
        public override String ToString() {
            return "importantValue1: " + importantValue1 +
                   " importantValue2: " + importantValue2 +
                   " importantValue3: " + importantValue3;
        }
    }
}
