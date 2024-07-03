//ObserverTester.cs - Application of the Object and Server classes. 


using Templates.Observer;

class ObserverTester 
{

	public static void Main()
	{

		Subject subj = new Subject();
		Observer o1 = new Observer(subj),
			o2 = new Observer(subj),
			o3 = new Observer(subj);

		subj.Attach(o1);
		subj.Attach(o2);

		subj.Notify();

	}

}
