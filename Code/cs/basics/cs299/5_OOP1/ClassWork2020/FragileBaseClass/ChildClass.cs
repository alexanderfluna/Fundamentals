using System;

namespace Overriding {

    public class ChildClass : BaseClass {
        public int Count = 0;

        public override void Add(int num)
        {
            collection.Add(num);
            Count++;
        }

        public new void AddAll(int[] arr)
        {
            foreach (int num in arr)
                this.Add(num);                

        }

    }    
}
