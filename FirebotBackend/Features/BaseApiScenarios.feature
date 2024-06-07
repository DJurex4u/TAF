Feature: BaseApiScenarios

A short summary of the feature

@tag1
Scenario: TC001
	Given JWT token is valid
	When I send a GET request to ""
		| Key           | Value               |
		| EndPoint      | retrieve anime list |
		| Authorization | <accessToken>       |
	#Then Reddit user is valid
