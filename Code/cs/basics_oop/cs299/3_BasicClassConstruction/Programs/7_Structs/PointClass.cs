#region Using directives

using System;
using System.Text;

#endregion

namespace StructApp1 {

    public class PointClass {

        // Fields
        private int x;
        private int y;

        // Constructor
        public PointClass(int x, int y) {
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
            PointClass other = (PointClass)obj;
            return other.x == x && other.y == y;
        }

        public override String ToString() {
            return "<" + x + ", " + y + ">";
        }

        public override int GetHashCode() {
            return x ^ y;
        }
    }
}
