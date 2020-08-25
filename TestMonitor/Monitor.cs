using NUnit.Engine;
using NUnit.Engine.Extensibility;
using NUnit.Framework;

namespace TestMonitor
{
    public class Monitor
    {
        [Extension]
        public class MyEventListener : ITestEventListener
        {
            public void OnTestEvent(string report)
            {
                TestContext.Out.WriteLine("Hello world 2" + report);
            }
        }
    }
}
