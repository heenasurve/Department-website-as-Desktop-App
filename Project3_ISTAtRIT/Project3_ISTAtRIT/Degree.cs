﻿using System.Collections.Generic;

namespace Project3_ISTAtRIT
{
    internal class Degree
    {

        public List<Undergraduate> undergraduate { get; set; }
        public List<Graduate> graduate { get; set; }
    }

    public class Undergraduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }
    }

    public class Graduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }
        public List<string> availableCertificates { get; set; }
    }

}