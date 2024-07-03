#region Using directives

using System;
using System.Text;

#endregion

namespace MoreComplexProperty {

    public class FileApplicationTester {
        static void Main(string[] args) {
			FileApplication app = new FileApplication();
			app.Filename = "Testing.Txt";
        }
    }
}
