Feature: Itinerary

A short summary of the feature

@tag1
Scenario: BookedItinerary
	Given Open Browser and Login Successfully
	When Click on Booked Itinerary button on menu
	Then Move to booked Itinerary page

Scenario: Cancel Booking
	Given Open Browser and Login Successfully
	When Click on Booked Itinerary button on menu and cancel booking
	Then booking cancel successful

Scenario: Search Order Id
	Given Open Browser and Login Successfully
	When Click on Booked Itinerary button on menu and Search Order Id
	Then Order Id Searched

Scenario: Logout from Itinerary
	Given Open Browser and Login Successfully
	When Click on Booked Itinerary button on menu and than logout from bottom button
	Then Successfull Logout