Feature: Checkboxes
  As site user
  I want to be able to click the checkboxes
  In order to see select the checkboxes

Background: Login and access the Checkboxes page
	Given I open The Internet page
		And I have entered valid login credentials
		And I have clicked the Checkboxes link

Scenario: Checkbox 2 is checked by default
	Then I see that checkbox 2 is checked

Scenario: Refreshing the page sets the checkboxes to the default state
	When I un-check checkbox 2
		And I check checkbox 1
		And I refresh the page 
	Then I can see that checkboxes are in the default state