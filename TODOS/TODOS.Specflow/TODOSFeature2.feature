Feature: TODOSFeature2
	

@FooterElementAll
Scenario: All
	When I press all
	Then counter shoul be equal ten

@FooterElementsActive
Scenario: Active
	When I press active
	Then counter shoul be equal ten

@FooterElementsCompleted
Scenario: Complited
	When I press complrtrd
	Then counter shoul be equal zero
