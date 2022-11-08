Feature: PlanetWeight

Caculates the users weight on a given planet

@tag1
Scenario: Calculate planet weight when weight is under 500
	Given the planet is mercury
	And the weight is 100
	When the planet weight is calculated
	Then the result is 37.8

@tag2
Scenario: Calculate planet surface gravity
	Given the planet is mercury
	When the planet surface gravity is calculated
	Then the result is 0.378