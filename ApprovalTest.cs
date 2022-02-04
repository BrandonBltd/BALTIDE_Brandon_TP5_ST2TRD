using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
        {

            var file = @"scriptConsole";
            
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\r"));
            Program.Main(new string[] { });
            var output = fakeoutput.ToString();
            var text = File.ReadAllText(file);
            //Approvals.Verify(output);
            Assert.AreEqual(text, output);
                
                
                //Console.SetIn(text);
               // StringBuilder fakeoutput = new StringBuilder();
                //Console.SetOut(new StringWriter(fakeoutput));
                //Program.Main(new string[] { });
               // var output = fakeoutput.ToString();

                //Approvals.Verify(output);
            
            
        }
    }
}
