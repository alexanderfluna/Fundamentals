// Observer.cs - Templates of The Observer and Subject classes. 


using System.Collections;

namespace Templates.Observer 
{

	public class Observer 
	{

		private Subject mySubject;

		public Observer (Subject s)
		{
			mySubject = s;
		}   

		public void Update()
		{
			SubjectState state = mySubject.GetState();

			//   if (the state is interesting){
			//      react on state change
			//   }
		}

	}

	public class Subject 
	{


		// Subject instance variable

		private ArrayList observers = new ArrayList();

		public void Attach(Observer o)
		{
			observers.Add(o);
		}

		public void Detach(Observer o)
		{
			observers.Remove(o);
		}

		public void Notify()
		{
			foreach(Observer o in observers)
				o.Update();
		}

		public SubjectState GetState()
		{
			return new SubjectState();
		}

	}

	public class SubjectState 
	{
		// Selected state of the subject
	}

}


