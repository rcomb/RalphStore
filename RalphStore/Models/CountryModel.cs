﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RalphStore.Models
{
    public class CountryModel
    {
        public int? ID { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public StateModel[] States { get; set; }
    }
}