Feature: TODOSFeature
		check names,
		data input,
		check counter

@OpenPage
Scenario: A_CheckName
	When I am on the page
	Then the title should be "AngularJS • TodoMVC"
	
@DataEntry
Scenario: B_DataInput
	When I am enter ten tasks
	Then counter shoul be equal ten


	