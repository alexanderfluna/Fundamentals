using System;
using System.Collections;

namespace Composite
{
    class SeqApp
    {

        // Test more than one level of composition
        public static void Main()
        {

            IntSequence isq =
              new IntCompositeSequence(
                    new IntCompositeSequence(
                      new IntInterval(3, 5), new IntSingular(17)),
                    new IntCompositeSequence(
                      new IntInterval(12, 7), new IntSingular(29)));

            Console.WriteLine("Min: {0} Max:{1}", isq.Min, isq.Max);

            // via isq's IEnumerator.MoveNext()
            foreach (int i in isq)
                Console.Write("{0,4}", i);

            Console.WriteLine();
        }
    }
}

// Output:
// Min: 3 Max:29
//   3   4   5  17  12  11  10   9   8   7  29