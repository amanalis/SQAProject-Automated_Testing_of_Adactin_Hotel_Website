using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Group Members (Aahil Ali_2012326_Sec_B, Anwer Aslam (2012334)_Sec_B & Aman Ali (2012375)_Sec_A//

namespace SpecFlowProject
{
    internal class Locators
    {
        // Login Page Locators
        public const string UserName = "username";
        public const string Password = "password";
        public const string LoginButton = "login";
        public const string WelcomeText = "//td[contains(text(),'Welcome to Adactin Group of Hotels')]";
        public const string NotLoginMessage = "//body[1]/table[2]/tbody[1]/tr[1]/td[2]/form[1]/table[1]/tbody[1]/tr[5]/td[2]/div[1]/b[1]";
        public const string NotUsername = "//span[@id='username_span']";
        public const string NotPassword = "//span[@id='password_span']";
        
        //booking
        public const string Search = "Submit";
        public const string location = "location";
        public const string SearchError = "//span[@id='location_span']";
        public const string SelectHotel = "radiobutton_1";
        public const string SelectHotel_Text = "//td[contains(text(),'Select Hotel')]";
        public const string ContinueBtn = "continue";
        public const string Reset_btn = "Reset";
        public const string BookHotel_Text = "//td[contains(text(),'Book A Hotel')]";
        public const string first_name = "first_name";
        public const string last_name = "last_name";
        public const string address = "address";
        public const string cc_num = "cc_num";
        public const string cc_type = "cc_type";
        public const string cc_exp_month = "cc_exp_month";
        public const string cc_exp_year = "cc_exp_year";
        public const string cc_cvv = "cc_cvv";
        public const string book_now = "book_now";
        public const string BookingConfirmation_text = "//td[contains(text(),'Booking Confirmation')]";
        public const string SelectHotel_error = "//label[@id='radiobutton_span']";
        public const string firstname_error = "//label[@id='first_name_span']";
        public const string logout_btn = "logout";
        public const string successful_logout_txt = "//body[1]/table[2]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]";
        public const string menu_logout = "//a[contains(text(),'Logout')]";
        public const string menu_Itinerary = "//a[contains(text(),'Booked Itinerary')]";
        public const string Booked_Itinerary= "//td[contains(text(),'Booked Itinerary')]";
        public const string order_cancelbtn = "/html[1]/body[1]/table[2]/tbody[1]/tr[2]/td[1]/form[1]/table[1]/tbody[1]/tr[2]/td[1]/table[1]/tbody[1]/tr[2]/td[3]/input[1]";
        public const string booking_canceled = "//label[@id='search_result_error']";
        public const string order_id_text = "order_id_text";
        public const string search_hotel_id = "search_hotel_id";
        public const string orderid_Xpath = "//input[@id='order_id_1246510']";
        public const string logout = "logout";
    }
}
