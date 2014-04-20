using TechTalk.SpecFlow;

namespace JustEatRAPPS.Spec.Common
{
    [Binding]
    internal class ScenarioBeforeAndAfter
    {
        [BeforeScenario]
        public static void Before()
        {
            
        }

        [AfterScenario]
        public static void After()
        {
            WebBrowser.Current.Dispose();
        }
    }
}
