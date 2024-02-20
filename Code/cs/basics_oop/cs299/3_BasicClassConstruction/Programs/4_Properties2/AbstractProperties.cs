using System;

namespace AbstractProperties {

    public interface GeometricFigure {
        // Abstract read-only property
        double Area { 
            get;
        }
    }

    public class Square : GeometricFigure {
        // Instance variable
        private double side;

        // Constructor
        public Square(double side) {
            this.side = side;
        }

        // Property from the interface implemented
        public double Area {
            get {
                return side * side;
            }
        }
    }
}
