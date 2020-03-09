Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers



Scenario: Scenario 1
	Given Some basic step
	And something else
	And my configuration is set
	And process is started
	When "On" channel is scanned



	Scenario: Scenario 2
	Given Some basic step
		And something else
		And my configuration is set
		And process is started
	When "On" channel is scanned
		Then Channel is "xx"
	When "Off" channel is scanned
	Then Channel is "yy"





	Scenario: Scenario 3
	Given Some basic step
	And something else
	And my configuration is set
	And my configuration is set with "8" something
	And process is started
	When "On" channel is scanned
	Then Channel is "xx"
	When "On" scan remote
	Then Remote is "Online"
	When "Off" scan remote
	Then Remote is "Offline"
	When "On" channel is scanned
	Then Channel is "xx"
	When "On" scan remote
	Then Remote is "Online"