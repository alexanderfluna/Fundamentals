using System;
using System.Collections;

namespace Overriding {

    public class BaseClass {

        // instance variable
        protected ArrayList collection = new ArrayList();  

        // Methods
        public virtual void Add(int num) {
            collection.Add(num);
        }

        public virtual void AddAll(int[] arr)
        {
            foreach (int num in arr)
                //this.Add(num);
                collection.Add(num);

        }

        // Queries
        public override string ToString() {
            string returnString = "[";
            foreach (int num in collection)
                returnString += " " + num;
            returnString += "]";
            return returnString;
        }
    }
}
