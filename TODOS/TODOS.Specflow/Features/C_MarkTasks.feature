Feature: C_MarkTasks
	I want to point out completed tasks
	and see how to change their number

Scenario: A_Marked two tasks
	Given I go to the Active tab
	When I marked two tasks
	Then on the tab Completed to be displayed two tasks
	And must appear ClearCompleted element

Scenario: B_Clear completed tasks
	When I click on button ClearCompleted
	Then on the tab Completed to be displayed zero tasks