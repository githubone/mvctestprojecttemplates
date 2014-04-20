using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WatiN.Core;
using NUnit.Framework;

namespace JustEatRAPPS.Spec.Common
{
    public class SearchPage : Page
    {
        private const string ErrorMessageDisplayId = "txtErrorMessage";
        private const string PostCodeId = "txtPostCode";
        private const string btnSearchId = "btnSearch";


        public string PostCode
        {
            get
            {
                return this.Document.TextField(Find.ById(PostCodeId)).Text;
            }
            set
            {
                Document.TextField(Find.ById(PostCodeId)).TypeText(value);
            }
        }

        public string ErrorMessageDisplay
        {
            get
            {
                return this.Document.Span(Find.ById(ErrorMessageDisplayId)).Text;
            }
        }

        public void ClickSearchIcon()
        {
            Document.Button(Find.ById(btnSearchId)).Click();
        }
    }
}
