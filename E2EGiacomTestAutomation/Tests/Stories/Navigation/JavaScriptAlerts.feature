Feature: JavaScriptAlerts
  As site user
  I want to be able to click JavaScript Alerts
  In order to see results appear

Background: Login and access the JavaScript Alerts page
	Given I open The Internet page
		And I have entered valid login credentials
		And I have clicked the JavaScript Alerts link

@ClearEnv
Scenario: Checking the result from the JS Alert button
	When I click the 'Click for JS Alert' button
		And I click the 'OK' button on the JavaScript Alert
	Then I can see the result: 'You successfuly clicked an alert'

Scenario: Checking the cancelled result from the JS Confirm button
	When I click the 'Click for JS Confirm' button
		And I click the 'Cancel' button on the JavaScript Alert
	Then I can see the result: 'You clicked: Cancel'

Scenario: Checking the result after adding text to the JS Prompt
	When I click the 'Click for JS Prompt' button
		And I send the text 'check1' to the JavaScript Prompt
		And I click the 'OK' button on the JavaScript Alert
	Then I can see the result: 'You entered: check1'