using TechTalk.SpecFlow;
using WatiN.Core;
using WatiN.Core.Native.Windows;

namespace JustEatRAPPS.Spec
{
    public static class WebBrowser
    {
        private const string Key = "browser";

        public static IE Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey(Key))
                {
                    var ie = new IE();
                    ie.AutoClose = true;
                    ie.ShowWindow(NativeMethods.WindowShowStyle.Minimize);
                    ie.ShowWindow(NativeMethods.WindowShowStyle.Maximize);

                    ScenarioContext.Current[Key] = ie;
                }

                return ScenarioContext.Current[Key] as IE;
            }
        }
    }
}
