﻿using System.Collections.Generic;

namespace Project3_ISTAtRIT
{
    internal class Minor
    {
        public List<UgMinor> UgMinors { get; set; }
    }

    public class UgMinor
    {
        public string name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }
        public string note { get; set; }
    }

}