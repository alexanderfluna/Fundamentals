// StringSet.cs - The class StringSet. 

using System;
using System.Collections;


namespace ConsoleApplication1
{
	public class StringSet 
	{

		private int capacity;
		private static int DefaultCapacity = 10;
		private string[] store;
		private int next;

		public StringSet(int capacity)
		{
			this.capacity = capacity;
			store = new string[capacity];
			next = 0;
		}

		public StringSet(): this(DefaultCapacity)
		{
		}

		public StringSet(string[] elements): this(elements.Length)
		{
			foreach(string el in elements) this.Insert(el);
		}

		// Copy constructor
		public StringSet(StringSet s): this(s.capacity)
		{
			foreach(string el in s) this.Insert(el);
		}

		public bool Member(string element)
		{
			for(int idx = 0; idx < next; idx++)
				if (element.Equals(store[idx]))
					return true;
			return false;
		}

		public void Insert(string element)
		{
			if (!this.Member(element))
			{
				if (this.Full)
				{
					Console.WriteLine("[Resize to {0}]", capacity * 2);
					Array.Resize<string>(ref store, capacity * 2);
					capacity = capacity * 2;
				}
				store[next] = element;
				next++;
			}
		}

		public void Delete(string element)
		{
			bool found = false;
			int  foundIdx = 0;
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
				store[next-1] = default(string);
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
		public bool Subset(StringSet other)
		{
			foreach(string e in this)
				if (!other.Member(e))
					return false;
			return true;
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
 
			private readonly StringSet set; 
			private int idx;

			public SetEnumerator (StringSet s)
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

		public override string ToString()
		{
			string elRes = "";
			for(int idx = 0; idx < next; idx++) 
				elRes += " " + store[idx];
			return "{" + elRes + " "+ "}";
		}

   
	}

}
