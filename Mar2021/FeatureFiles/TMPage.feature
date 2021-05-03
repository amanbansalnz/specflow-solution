Feature: Testing Functionality around TM Page 
	
@mytag
Scenario:  I am to create the TMPage
	Given I am logged in
    And I am at the TMPage
    When I click the create new button
    And I enter the details for the new TM
    And Click save button
    And I click the last page button
    Then Validate the TM is created
