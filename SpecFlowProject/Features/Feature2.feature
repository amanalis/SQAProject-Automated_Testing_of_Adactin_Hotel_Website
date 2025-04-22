Feature: Booking

A short summary of the feature

@tag1
Scenario: Direct click on Search
	Given  Open Browser and Login
	When Directly click Search Button
	Then Error on Location tab

Scenario: Successful Booking
	Given  Open Browser and Login
	When Do the booking process correctly
	Then Booking Successful

Scenario: Direct click on Continue
	Given  Open Browser and Login
	When Directly click on Contine after hotel Search
	Then Error on Continue Btn

Scenario: Direct click on Book Now
	Given  Open Browser and Login
	When Directly click on BookNow after hotel Search and continue
	Then Error on Book Now Btn

Scenario: Successful Booking and logout
	Given  Open Browser and Login
	When Do the booking process correctly and press logout button
	Then Successful Logout

Scenario: click on Reset
	Given  Open Browser and Login
	When Search hotel and then press reset
	Then Columns reset

Scenario: click on Menu Logout
	Given  Open Browser and Login
	When Press Menu Logout Button
	Then Successfull logout