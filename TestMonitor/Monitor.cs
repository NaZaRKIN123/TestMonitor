using NUnit.Engine;
using NUnit.Engine.Extensibility;
using System;

namespace TestMonitor
{
	[Extension]
	public class MyEventListener : ITestEventListener
	{
		public void OnTestEvent(string report)
		{
			Console.WriteLine("Hello world 2" + report);
		}
	}
}
