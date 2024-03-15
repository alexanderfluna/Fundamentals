using System;

namespace StructApp1 {

    public struct Point {

        // Fields
        private int x;
        private int y;

        // Constructor
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        // Properties
        public int X {
            get {
                return x;
            }
            set {
                x = value;
            }
        }

        public int Y {
            get {
                return y;
            }
            set {
                y = value;
            }
        }

        // Queries
        public override bool Equals(Object obj) {
            Point other = (Point)obj;
            return other.x == x && other.y == y;
        }

        public override int GetHashCode() {
            return x ^ y;
        }

        public override String ToString() {
            return "<" + x + ", " + y + ">";
        }
    }
}
