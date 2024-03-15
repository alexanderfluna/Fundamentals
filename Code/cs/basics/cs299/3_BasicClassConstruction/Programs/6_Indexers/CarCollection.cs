using System;

namespace IndexerApplication {

    public class CarCollection {

        private String[] cars = {"Ford", "Toyota", "Saab", "Volvo",  
 							  "Chevy", "Dodge", "Mercedes"};

        // Properties
        public int Size {
            get {
                return cars.Length;
            }
        }

        public String this[int index] {
            get {
                if (index >= 1 && index <= 7) {
                    return cars[index - 1];
                } else {
                    return "Illegal index";
                }
            }
            set {
                if (index >= 1 && index <= 7) {
                    cars[index - 1] = value;
                }
            }
        }
    }
}

