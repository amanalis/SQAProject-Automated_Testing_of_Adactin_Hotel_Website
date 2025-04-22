using System;
using SpecFlowProject.PageClasses;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class ItineraryStepDefinitions
    {
        ItineraryPage itineraryPage = new ItineraryPage();
        LoginPageClass loginPageClass = new LoginPageClass();
        Booking booking = new Booking();

        [Given(@"Open Browser and Login Successfully")]
        public void GivenOpenBrowserAndLoginSuccessfully()
        {
            itineraryPage.DriverConfigure();
            itineraryPage.OpenBrowserAndURL();
            loginPageClass.LoginMethod();
            loginPageClass.ValidateSuccessfullLogin();
        }

        [When(@"Click on Booked Itinerary button on menu")]
        public void WhenClickOnBookedItineraryButtonOnMenu()
        {
            itineraryPage.Menu_Itinerarybtn();
        }

        [Then(@"Move to booked Itinerary page")]
        public void ThenMoveToBookedItineraryPage()
        {
            itineraryPage.BookedItinerary_txt();
            itineraryPage.CloseBrowser();
        }

        [When(@"Click on Booked Itinerary button on menu and cancel booking")]
        public void WhenClickOnBookedItineraryButtonOnMenuAndCancelBooking()
        {
            itineraryPage.Menu_Itinerarybtn();
            itineraryPage.CancelSingleOrder();
        }

        [Then(@"booking cancel successful")]
        public void ThenBookingCancelSuccessful()
        {
            itineraryPage.BookingCancel_txt();
            itineraryPage.CloseBrowser();
        }

        [When(@"Click on Booked Itinerary button on menu and Search Order Id")]
        public void WhenClickOnBookedItineraryButtonOnMenuAndSearchOrderId()
        {
            itineraryPage.Menu_Itinerarybtn();
            itineraryPage.Searched_OrderId();
        }

        [Then(@"Order Id Searched")]
        public void ThenOrderIdSearched()
        {
            itineraryPage.Searched_OrderId();
            itineraryPage.CloseBrowser();
        }

        [When(@"Click on Booked Itinerary button on menu and than logout from bottom button")]
        public void WhenClickOnBookedItineraryButtonOnMenuAndThanLogoutFromBottomButton()
        {
            itineraryPage.Menu_Itinerarybtn();
            itineraryPage.Logout_btn();
        }

        [Then(@"Successfull Logout")]
        public void ThenSuccessfullLogout()
        {
            booking.Successful_logouttxt();
            itineraryPage.CloseBrowser();
        }



    }
}
