Feature: Login

A short summary of the feature

@functional
Scenario: Login Scenario with valid Username and password
	Given Open Browser to goto URL 
	When Enter valid username and password
	Then User should login

Scenario: Login Scenario with invalid Username and password
	Given Open Browser to goto URL 
	When Enter invalid username and password
	Then User should not login

Scenario: Login Scenario with no Username 
	Given Open Browser to goto URL 
	When Enter only password
	Then User will get username error

Scenario: Login Scenario with no password
	Given Open Browser to goto URL 
	When Enter only username
	Then User will get password error

Scenario: Login Scenario with no username and password
	Given Open Browser to goto URL 
	When Enter without username and password
	Then User will get username error