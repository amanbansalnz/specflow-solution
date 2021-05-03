Feature: Fucntionality around Company Page

Scenario: I am able to create the company
	Given I am logged in
    And I am at the company page
    When I click the create new button
    And Enter the details for the new company
    And Click save company button
    And I click the last page button
    Then Validate the company is created

Scenario: I am able to edit the company
	Given I am logged in
    And I am at the company page
    When I click the edit button
    And I edit the details
    And I click save company button
    Then Validate that company I edited was saved

Scenario: I am able to delete the company
	Given I am logged in
    And I am at the company page
    When I click the last page button
    And I click delete button
    And I confirm okay to delete
    Then Validate the company is deleted

