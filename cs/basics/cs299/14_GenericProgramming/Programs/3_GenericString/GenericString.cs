// GenericString.cs - The class String<T>. 

using System;
 
namespace ConsoleApplication1
{
	public class String<T>: IComparable<String<T>> where T: IComparable<T>{
  
	private T[] content;

	public String(){
		content = new T[0];
	}

	public String(T e){
		content = new T[]{e}; 
	}

	public String(T e1, T e2){
		content = new T[]{e1, e2}; 
	}

	public String(T e1, T e2, T e3){
		content = new T[]{e1, e2, e3}; 
	}

	public int CompareTo(String<T> other){
		int thisLength = this.content.Length,
			otherLength = other.content.Length;
	 
		for (int i = 0; i < Math.Min(thisLength,otherLength); i++){
		if (this.content[i].CompareTo(other.content[i]) < 0)  
			return -1;
		else if (this.content[i].CompareTo(other.content[i]) > 0)
			return 1;
		}
		// prefixes of this and other are pair-wise equal.
		if (thisLength < otherLength)
		return -1;
		else if (thisLength > otherLength)
		return 1;
		else return 0;
	}

	public override string ToString(){
		string res = "[";
		for(int i = 0; i < content.Length;i++){
			res += content[i];
			if (i < content.Length - 1) res += ", ";
		}
		res += "]";
		return res;
	} 

  }
}
