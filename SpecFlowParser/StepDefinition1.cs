using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowParser
{
	[Binding]
	public sealed class StepDefinition1
	{
		//[Given(@"my configuration is set\s?(with ""([0-9, ]*)"" something)?")]
		[Given(@"my configuration is set( with ""([0-9, ]*)"" something)?")]
		//[Given(@"my configuration is set {0,1}(with ""([0-9, ]*)"" something)?")]
		public void MyConfigurationIsSet(string optional, string something)
		{
			
		}

		[Then(@"Channel( with "".+"")? is ""(xx|yy)""")]
		//[Then(@"Channel {0,1}(with "".+"")? is ""(xx|yy)""")]
		[When(@"Channel( with "".+"")? is ""(xx|yy)""")]
		public void WhenChannelIs(string inputChannel, string state)
		{

		}
	}
}
