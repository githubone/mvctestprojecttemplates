using JustEatRAPPS.Spec.Common;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JustEatRAPPS.Spec
{
    [Binding]
    public class SearchRestaurantsSteps
    {
        [When]
        public void When_I_enter_an_invalid_postcode_of_POSTCODE(string postCode)
        {
            var searchPage = WebBrowser.Current.Page<SearchPage>();
            searchPage.PostCode = postCode == "empty" ? string.Empty :postCode;
        }

        [When]
        public void When_click_the_search_icon()
        {
            var searchPage = WebBrowser.Current.Page<SearchPage>();
            searchPage.ClickSearchIcon();
        }
        
        [Then]
        public void Then_the_validation_error_message_should_read_ERRORMESSAGE(string errorMessage)
        {
            var searchPage = WebBrowser.Current.Page<SearchPage>();
            var messageDisplay = searchPage.ErrorMessageDisplay;

            Assert.AreEqual(errorMessage, messageDisplay);
        }
    }
}
