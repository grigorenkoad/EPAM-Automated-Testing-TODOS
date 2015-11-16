Feature: A_OpenPage
	As a tester
	I want to check the presence of elements on the page

@Setup
Scenario: Presence of elements
	When I go to the page
	Then the title should be "AngularJS • TodoMVC"
	And element should be present
