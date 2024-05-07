// Nullable.cs - A partial reproduction of struct Nullable. 

using System;


namespace ConsoleApplication1
{
	public struct Nullable<T> where T : struct{

	private T value;
	private bool hasValue;

	public Nullable(T value){
		this.value = value;
		this.hasValue = true;
	}

	public bool HasValue{
		get{
		return hasValue;
		}
	}

	public T Value{
		get{
		if(hasValue)
			return value;
		else throw new InvalidOperationException();
		}
	}

  }
}
