Feature: User login
  As site user
  I want to be able to log in
  In order to see landing page

Background:
	Given I open The Internet page

@ClearEnv
Scenario: User log in with valid credentials
	When I enter valid login credentials
	Then I see landing page

Scenario: User logged out cannot reach landing page
	When I enter valid login credentials
		And I click the logout button
	Then I cannot access the landing page