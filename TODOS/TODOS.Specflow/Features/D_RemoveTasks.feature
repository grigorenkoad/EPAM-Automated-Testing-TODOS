Feature: D_RemoveTasks
	I want to remove tasks 
	and count their number


Scenario: A_Remove one task
	When I Remove one task
	Then their stays seven


Scenario: B_Remove all tasks
	When I Remove all tasks
	Then their stays zero
