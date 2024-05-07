// ObjectSet.cs - The class ObjectSet. 


using System;
using System.Collections;

namespace ConsoleApplication1
{
	public class ObjectSet 
	{

		private int capacity;
		private static int DefaultCapacity = 10;
		private Object[] store;
		private int next;

		public ObjectSet(int capacity)
		{
			this.capacity = capacity;
			store = new Object[capacity];
			next = 0;
		}

		public ObjectSet(): this(DefaultCapacity)
		{
		}

		public ObjectSet(Object[] elements): this(elements.Length)
		{
			foreach(Object el in elements) this.Insert(el);
		}

		// Copy constructor
		public ObjectSet(ObjectSet s): this(s.capacity)
		{
			foreach(Object  el in s) this.Insert(el);
		}

		public bool Member(Object  element)
		{
			for(int idx = 0; idx < next; idx++)
				if (element.Equals(store[idx]))
					return true;
			return false;
		}

		public void Insert(Object  element)
		{
			if (!this.Member(element))
			{
				if (this.Full)
				{
					Console.WriteLine("[Resize to {0}]", capacity * 2);
					Array.Resize<Object>(ref store, capacity * 2);
					capacity = capacity * 2;
				}
				store[next] = element;
				next++;
			}
		}

		public void Delete(Object  element)
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
				store[next-1] = default(Object  );
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
		public bool Subset(ObjectSet other)
		{
			foreach(Object  e in this)
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
 
			private readonly ObjectSet set; 
			private int idx;

			public SetEnumerator (ObjectSet s)
			{
				this.set = s;
				idx = -1;   // position enumerator outside range
			}
 
			public Object  Current
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
