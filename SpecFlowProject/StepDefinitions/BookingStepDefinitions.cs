using System;
using OpenQA.Selenium.Chrome;
using SpecFlowProject.PageClasses;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class BookingStepDefinitions
    {
        LoginPageClass loginPageClass = new LoginPageClass();
        Booking booking = new Booking();

        [Given(@"Open Browser and Login")]
        public void GivenOpenBrowserAndLogin()
        {
            loginPageClass.DriverConfigure();
            loginPageClass.OpenBrowserAndURL();
            loginPageClass.LoginMethod();
            loginPageClass.ValidateSuccessfullLogin();
        }    
        

        [When(@"Directly click Search Button")]
        public void WhenDirectlyClickSearchButton()
        {
            booking.SearchTap();
        }

        [Then(@"Error on Location tab")]
        public void ThenErrorOnLocationTab()
        {
            booking.LocationError();
            booking.CloseBrowser();
        }
        /// <summary>
        /// Successfull Booking
        /// </summary>
        
        [When(@"Do the booking process correctly")]
        public void WhenDoTheBookingProcessCorrectly()
        {
            booking.SearchHotel();
            booking.SelectHotel();
            booking.BookAHotel();
        }

        [Then(@"Booking Successful")]
        public void ThenBookingSuccessful()
        {
            booking.SuccessfullBooking();
            booking.CloseBrowser();
        }

        [When(@"Directly click on Contine after hotel Search")]
        public void WhenDirectlyClickOnContineAfterHotelSearch()
        {
            booking.SearchHotel();
            booking.ContinueTap();
        }

        [Then(@"Error on Continue Btn")]
        public void ThenErrorOnContinueBtn()
        {
            booking.SelectHotel_Error();
            booking.CloseBrowser();
        }

        [When(@"Directly click on BookNow after hotel Search and continue")]
        public void WhenDirectlyClickOnBookNowAfterHotelSearchAndContinue()
        {
            booking.SearchHotel();
            booking.SelectHotel();
            booking.BookNowTap();
        }

        [Then(@"Error on Book Now Btn")]
        public void ThenErrorOnBookNowBtn()
        {
            booking.BookNow_Error();
            booking.CloseBrowser();
        }

        [When(@"Do the booking process correctly and press logout button")]
        public void WhenDoTheBookingProcessCorrectlyAndPressLogoutButton()
        {
            booking.SearchHotel();
            booking.SelectHotel();
            booking.BookAHotel();
           // booking.Logout_Successfulbooking();
        }

        [Then(@"Successful Logout")]
        public void ThenSuccessfulLogout()
        {
            //booking.Successful_logouttxt();
            booking.CloseBrowser();
        }

        [When(@"Search hotel and then press reset")]
        public void WhenSearchHotelAndThenPressReset()
        {
            booking.Reset_btn();
        }

        [Then(@"Columns reset")]
        public void ThenColumnsReset()
        {
            booking.CloseBrowser();
        }

        [When(@"Press Menu Logout Button")]
        public void WhenPressMenuLogoutButton()
        {
            booking.Menu_Logout();
        }

        [Then(@"Successfull logout")]
        public void ThenSuccessfullLogout()
        {
            booking.Successful_logouttxt();
            booking.CloseBrowser();
        }

    }
}
