using System;

namespace Fractions {

    /*
     * Models the behavior of a rational number
    */
    public class Fraction {
        // Fields
        private int numerator;
        private int denominator = 1;

        // Constructors
        public Fraction() {
            numerator = 0;
            denominator = 1;
        }

        public Fraction(int numerator, int denominator) {
            if (denominator == 0) {
                throw new Exception("Cannot have zero denominator.");
            }
            this.numerator = numerator;
            this.denominator = denominator;
            Reduce();
        }

        public Fraction(int numerator) {
            this.numerator = numerator;
            denominator = 1;
        }

        // Properties
        public int Numerator {
            get {
                return numerator;
            }
            set {
                numerator = value;
                Reduce();
            }
        }

        public int Denominator {
            get {
                return denominator;
            }
            set {
                if (value == 0) {
                    throw new Exception("Cannot have zero denominator");
                }
                denominator = value;
                Reduce();
            }
        }

        // Static overloaded operators
        public static bool operator ==(Fraction f1, Fraction f2) {
            return (f1.numerator == f2.numerator &&
                    f1.denominator == f2.denominator);
        }

        public static bool operator !=(Fraction f1, Fraction f2) {
            return !(f1 == f2);
        }

        public static bool operator >(Fraction f1, Fraction f2) {
            return f1.numerator * f2.denominator >
                     f2.numerator * f1.denominator;
        }

        public static bool operator <(Fraction f1, Fraction f2) {
            return f1.numerator * f2.denominator <
                    f2.numerator * f1.denominator;
        }

        public static Fraction operator +(Fraction f1, Fraction f2) {
            return (new Fraction(f1.numerator * f2.denominator +
                        f2.numerator * f1.denominator,
                        f1.denominator * f2.denominator));
        
        }

        public static Fraction operator -(Fraction f1, Fraction f2) {
            return (new Fraction(f1.numerator * f2.denominator -
                        f2.numerator * f1.denominator,
                        f1.denominator * f2.denominator));
        }

        public static Fraction operator *(Fraction f1, Fraction f2) {
            return (new Fraction(f1.numerator * f2.numerator,
                        f1.denominator * f2.denominator));
        }

        public static Fraction operator /(Fraction f1, Fraction f2) {
            return (new Fraction(f1.numerator * f2.denominator,
                        f1.Denominator * f2.Numerator));
        }

        // Predicatess related to comparison
        public override bool Equals(Object obj) {
            if (obj is Fraction) 
                return /* (this.numerator == ((Fraction)obj).numerator &&
                        this.denominator == ((Fraction)obj).denominator);*/
					   this == (Fraction) obj;
            else 
                return false;
            
        }

        public override int GetHashCode() {
            double value = (double)numerator / denominator;
            return value.GetHashCode();
        }

        // Conversion
        public double ToDouble() {
            return (double)numerator / denominator;
        }

        // Display
        public override String ToString() {
            String sign = "";
            if (numerator == 0) {
                return "0";
            }
            if (numerator * denominator < 0) {
                sign = "-";
            }
            if (denominator == 1) {
                return sign + Math.Abs(numerator);
            }
            return sign + Math.Abs(numerator) + "/" +
                                        Math.Abs(denominator);
        }

        // Internal use
        private Fraction Reduce() {
            int gcd = Math.Abs(numerator) > Math.Abs(denominator) ?
                      Math.Abs(denominator) : Math.Abs(numerator);
            if (gcd == 0) {
                return this;
            }
            while (gcd != 1 &&
                    (numerator % gcd != 0 || denominator % gcd != 0)) {
                gcd--;
            }
            numerator /= gcd;
            denominator /= gcd;
            return this;
        }
    }
}
