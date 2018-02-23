using System.Collections.Generic;

namespace Project3_ISTAtRIT
{
    internal class News
    {
        public List<Year> year { get; set; }
        public List<Quarter> quarter { get; set; }
        public List<Older> older { get; set; }
    }

public class Year
    {
        public string date { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Quarter
    {
        public string date { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Older
    {
        public string date { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

   
}