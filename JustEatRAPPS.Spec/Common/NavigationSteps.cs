using TechTalk.SpecFlow;

namespace JustEatRAPPS.Spec
{
    [Binding]
    public class NavigationSteps
    {
        [Given]
        public void Given_I_am_on_JustEatRAPPS_site()
        {
            WebBrowser.Current.GoTo("http://localhost:50211/");
        }


    }
}
