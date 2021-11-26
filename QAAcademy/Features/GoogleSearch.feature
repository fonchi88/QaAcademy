Feature: GoogleSearch
	Simple Search Box that returns the results below

@mytag
	Scenario: Search for a keyword in Google
	Given I Navigate to Google
	When When I type Keyword 
	Then At least one result should contain Keyword 