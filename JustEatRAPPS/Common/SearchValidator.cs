using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace JustEatRAPPS.Common
{
    public class SearchValidator : ISearchValidator
    {
        public bool IsValid(string postCode)
        {
            return IsPostCodeAvailable(postCode) && IsPostCodeValid(postCode);
        }

        private bool IsPostCodeAvailable(string postCode)
        {
            return !string.IsNullOrEmpty(postCode);
        }

        private bool IsPostCodeValid(string postCode)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{2}\d{2}$");
            return regex.IsMatch(postCode.ToUpper().Trim());
        }
    }
}