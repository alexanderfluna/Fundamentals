namespace NamespaceApp
{
    public class App
    {
        public void Talk()
        {
            System.Console.WriteLine("App in NamespaceApp");
        }

        static void Main(string[] args)
        {
            // NamespaceApp
            App appObject = new App();
            appObject.Talk();

            // Namespace1
            Namespace1.Class1 class1 = new Namespace1.Class1();
            class1.Talk();

            // Namespace2
            Namespace2.Class2 class2 = new Namespace2.Class2();
            class2.Talk();

            // Namespace3
            Namespace3.Class3 class3 = new Namespace3.Class3();
            class3.Talk();

            // Namespace.Namespace4
            Namespace3.Namespace4.Class4 class4 = new Namespace3.Namespace4.Class4();
            class4.Talk();
        }
    }
}