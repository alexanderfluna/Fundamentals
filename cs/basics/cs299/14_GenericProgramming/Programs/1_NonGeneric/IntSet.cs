// IntSet.cs - The class IntSet. 


using System;
using System.Collections;

namespace ConsoleApplication1
{
	public class IntSet 
	{

		private int capacity;
		private static int DefaultCapacity = 10;
		private int[] store;
		private int next;

		public IntSet(int capacity)
		{
			this.capacity = capacity;
			store = new int[capacity];
			next = 0;
		}

		public IntSet(): this(DefaultCapacity)
		{
		}

		public IntSet(int[] elements): this(elements.Length)
		{
			foreach(int  el in elements) this.Insert(el);
		}

		// Copy constructor
		public IntSet(IntSet s): this(s.capacity)
		{
			foreach(int  el in s) this.Insert(el);
		}

		public bool Member(int  element)
		{
			for(int idx = 0; idx < next; idx++)
				if (element.Equals(store[idx]))
					return true;
			return false;
		}

		public void Insert(int  element)
		{
			if (!this.Member(element))
			{
				if (this.Full)
				{
					Console.WriteLine("[Resize to {0}]", capacity * 2);
					Array.Resize<int>(ref store, capacity * 2);
					capacity = capacity * 2;
				}
				store[next] = element;
				next++;
			}
		}

		public void Delete(int  element)
		{
			bool found = false;
			int foundIdx = 0;
			for(int idx = 0; !found && (idx < next); idx++)
			{
				if (element.Equals(store[idx]))
				{
					found = true;
					foundIdx = idx;
				}
			}
			if (found)
			{   // shift remaining elements left
				for(int idx = foundIdx+1; idx < next; idx++)
					store[idx-1] = store[idx];
				store[next-1] = default(int  );
					next--;
			}
		}

		public int Count
		{
			get
			{
				return next;
			}
		}

		// Is this set a subset of other
		public bool Subset(IntSet other)
		{
			foreach(int  e in this)
				if (!other.Member(e))
					return false;
			return true;
		}
     
		public override string ToString()
		{
			string elRes = "";
			for(int idx = 0; idx < next; idx++) 
				elRes += " " + store[idx];
			return "{" + elRes + " "+ "}";
		}

		private bool Full
		{
			get
			{
				return next == capacity;
			}
		}

		public IEnumerator GetEnumerator ()
		{
			return new SetEnumerator(this);
		}
  
		private class SetEnumerator: IEnumerator
		{
 
			private readonly IntSet set; 
			private int idx;

			public SetEnumerator (IntSet s)
			{
				this.set = s;
				idx = -1;   // position enumerator outside range
			}
 
			public Object Current
			{ 
				get 
				{
					return set.store[idx];
				}
			}

			public bool MoveNext()
			{
				if (idx < set.next - 1)
				{
					idx++; 
					return true;
				}
				else
					return false;
			}

			public void Reset()
			{
				idx = -1;         
			}

			public void Dispose()
			{
			}

		}    
   
	}

}
