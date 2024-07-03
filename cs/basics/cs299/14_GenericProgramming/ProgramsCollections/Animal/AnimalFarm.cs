// AnimalFarm.cs - A class AnimalFarm - a subclass of Collection<Animal> - 
// testing protected members. 

using System;
using System.Collections.ObjectModel;

public class AnimalFarm: Collection<Animal>{

  protected override void InsertItem(int i, Animal a){
    base.InsertItem(i,a);
    Console.WriteLine("**InsertItem: {0}, {1}", i, a);
  }

  protected override void SetItem(int i, Animal a){
    base.SetItem(i,a);
    Console.WriteLine("**SetItem: {0}, {1}", i, a);
  }

  protected override void RemoveItem(int i){
    base.RemoveItem(i);
    Console.WriteLine("**RemoveItem: {0}", i);
  }

  protected override void ClearItems(){
    base.ClearItems();
    Console.WriteLine("**ClearItems");
  }

}
