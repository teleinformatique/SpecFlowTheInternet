Feature: Login

A short summary of the feature

@tag1
Scenario:  I can log in succesffuly
	Given i am on home page
	When i click on login link
	And enter login tomsmith with password SuperSecretPassword!
	Then the message Welcome to the Secure Area. When you are done click logout below. is displayed
