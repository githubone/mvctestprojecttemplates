﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Menus
{

    internal class AvailableDuring
    {

        [JsonProperty("Monday")]
        public Monday Monday { get; set; }

        [JsonProperty("Tuesday")]
        public Tuesday Tuesday { get; set; }

        [JsonProperty("Wednesday")]
        public Wednesday Wednesday { get; set; }

        [JsonProperty("Thursday")]
        public Thursday Thursday { get; set; }

        [JsonProperty("Friday")]
        public Friday Friday { get; set; }

        [JsonProperty("Saturday")]
        public Saturday Saturday { get; set; }

        [JsonProperty("Sunday")]
        public Sunday Sunday { get; set; }
    }

}