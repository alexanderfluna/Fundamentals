// GenericSet.cs - The class Set<T>. 

using System;
using System.Collections.Generic;
using System.Collections;


namespace TestingProject
{
	public class Set<T> {

	private int capacity;
	private static int DefaultCapacity = 10;
	private T[] store;
	private int next;

	public Set(int capacity){
		this.capacity = capacity;
		store = new T[capacity];
		next = 0;
	}

	public Set(): this(DefaultCapacity){
	}

	public Set(T[] elements): this(elements.Length){
		foreach(T el in elements) this.Insert(el);
	}

	// Copy constructor
	public Set(Set<T> s): this(s.capacity){
		foreach(T el in s) this.Insert(el);
	}

	public bool Member(T element){
		for(int idx = 0; idx < next; idx++)
		if (element.Equals(store[idx]))
			return true;
		return false;
	}

	public void Insert(T element){
		if (!this.Member(element)){
		if (this.Full){
			Console.WriteLine("[Resize to {0}]", capacity * 2);
			Array.Resize<T>(ref store, capacity * 2);
			capacity = capacity * 2;
		}
		store[next] = element;
		next++;
		}
	}

	public void Delete(T element){
		bool found = false;
		int  foundIdx = 0;
		for(int idx = 0; !found && (idx < next); idx++){
		if (element.Equals(store[idx])){
			found = true;
			foundIdx = idx;
		}
		}
		if (found){   // shift remaining elements left
		for(int idx = foundIdx+1; idx < next; idx++)
			store[idx-1] = store[idx];
		store[next-1] = default(T);
		next--;
		}
	}

	public int Count{
		get{
		return next;
		}
	}

	// Is this set a subset of other
	public bool Subset(Set<T> other){
		foreach(T e in this)
		if (!other.Member(e))
			return false;
		return true;
	}
     
	public override string ToString(){
		string elRes = "";
		for(int idx = 0; idx < next; idx++) 
		elRes += " " + store[idx];
		return "{" + elRes + " "+ "}";
	}

	private bool Full{
		get{
		return next == capacity;
		}
	}

	public IEnumerator<T> GetEnumerator (){
		return new SetEnumerator(this);
	}
  
	private class SetEnumerator: IEnumerator<T>{
	 
		private readonly Set<T> set; 
		private int idx;

		public SetEnumerator (Set<T> s){
		this.set = s;
		idx = -1;   // position enumerator outside range
		}
	 
		public T Current{ 
			get {
				return set.store[idx];
			}
		}

		Object IEnumerator.Current{ 
			get {
				return set.store[idx];
			}
		}

		public bool MoveNext(){
		if (idx < set.next - 1){
			idx++; 
			return true;
		}
		else
			return false;
		}

		public void Reset(){
		idx = -1;         
		}

		public void Dispose(){
		}
	}      
  }
}
