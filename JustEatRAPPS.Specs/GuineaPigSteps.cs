using System;
using TechTalk.SpecFlow;

namespace JustEatRAPPS.Specs
{
    [Binding]
    public class GuineaPigSteps
    {
        [Given(@"I have entered '(.*)' into the commentbox")]
        public void GivenIHaveEnteredIntoTheCommentbox(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press '(.*)'")]
        public void WhenIPress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"my comment '(.*)' is displayed on the screen")]
        public void ThenMyCommentIsDisplayedOnTheScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
