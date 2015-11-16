Feature: B_DataEntry
	I want to enter the data 
	and check whether the number 
	that indicates the counter


Scenario: Add ten tasks
	When I add ten tasks
	Then must appear footer elements 
	And on the tab All to be displayed ten tasks
	And on the tab Active to be displayed ten tasks
	And on the tab Completed to be displayed zero tasks


	

