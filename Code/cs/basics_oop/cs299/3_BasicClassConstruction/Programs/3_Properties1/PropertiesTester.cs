#region Using directives

using System;
using System.Text;

#endregion

namespace IntroducingProperties {
  class PropertiesTester {
	public static void Main() {
		SimplePropertiesApplication app = new SimplePropertiesApplication(17);
		app.ImportantValue2 = 14;
		app.ImportantValue3 = "ABCDEFG";
		Console.WriteLine("importantValue1 = " + app.ImportantValue1);
		Console.WriteLine(app.ToString());
		Console.ReadLine();
	}
  }
}

