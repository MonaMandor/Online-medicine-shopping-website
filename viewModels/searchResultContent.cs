﻿using Online_Medicine_Shopping_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Medicine_Shopping_Website.viewModels
{
    public class searchResultContent
    {
        public List<Product> products { get; set; }
        public string title { get; set; }
    }
}