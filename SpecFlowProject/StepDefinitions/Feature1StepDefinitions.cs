using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        LoginPageClass loginPageClass = new LoginPageClass();
        [Given(@"Open Browser to goto URL")]
        public void GivenOpenBrowserToGotoURL()
        {
            loginPageClass.DriverConfigure();
            loginPageClass.OpenBrowserAndURL();
        }

        [When(@"Enter valid username and password")]
        public void WhenEnterValidUsernameAndPassword()
        {
            loginPageClass.LoginMethod();
        
        }

        [Then(@"User should login")]
        public void ThenUserShouldLogin()
        {
            loginPageClass.ValidateSuccessfullLogin();
            loginPageClass.CloseBrowser();
        }

        [When(@"Enter invalid username and password")]
        public void WhenEnterInvalidUsernameAndPassword()
        {
            loginPageClass.InvalidLoginMethod();
        }

        [Then(@"User should not login")]
        public void ThenUserShouldNotLogin()
        {
            loginPageClass.ValidateUnsuccessssulLogin();
            loginPageClass.CloseBrowser();
        }

        [When(@"Enter only password")]
        public void WhenEnterOnlyPassword()
        {
            loginPageClass.NoUsernameLoginMethod();
        }

        [Then(@"User will get username error")]
        public void ThenUserWillGetUsernameError()
        {
            loginPageClass.usernameNotEntered();
            loginPageClass.CloseBrowser();
        }

        [When(@"Enter only username")]
        public void WhenEnterOnlyUsername()
        {
            loginPageClass.NoPasswordLoginMethod();
        }

        [Then(@"User will get password error")]
        public void ThenUserWillGetPasswordError()
        {
            loginPageClass.passwordNotEntered();
            loginPageClass.CloseBrowser();
        }

        [When(@"Enter without username and password")]
        public void WhenEnterWithoutUsernameAndPassword()
        {
            loginPageClass.NoUsernameAndPasswordLoginMethod();
        }


    }
}
