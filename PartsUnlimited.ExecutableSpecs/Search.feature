Feature: Search
	In order to find products to buy
	As a customer
	I want to be able to search for products

Scenario: Search by keyword
	Given I am on the homepage
	And I have entered the keyword 'bugeye'
	When I search
	Then results should contain 'bugeye'
