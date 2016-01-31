Feature: Validaterecommendations
	In order buy more products
	As a customer
	I want to see alternative products I could buy

@mytag
Scenario Outline: Recommend alternative Products
	Given I have bought a <product>
	When I ask alternative products
	Then the result should include my original <product>

	Examples: 
	| product        |
	| 'Batery'       |
	| 'Halogen light'|
