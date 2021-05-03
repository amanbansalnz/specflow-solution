Feature: Login Page
	In order to test the login functionality
	As a user
	I want to be able to validate the login works
	
Scenario: When a valid cred are used should result in successful login
	Given I am at the login page
	And I validate that I am at the login page 
	When I enter valid creds
	And I click the login button
	Then I should be logged in successfully

Scenario: When invalid username is used should result in failure to login
	Given I am at the login page
	And I validate that I am at the login page 
	When I login with username 'name1234'
	And I click the login button
	Then I should be not logged in

Scenario: When password is not valid should result failure to login 
	Given I am at the login page
	And I validate that I am at the login page 
	When I login with <username> and with <password>
	And I click the login button
	Then I should be not logged in
	Examples: 
	| username | password  |
	| hari123  | 123451324 |
	| abca1234 | 000test   |

