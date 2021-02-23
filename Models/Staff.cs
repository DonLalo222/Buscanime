using System;
using System.Collections.Generic;

namespace Buscanime.Models
{
    public class Staff
    {
        public int mal_id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string image_url { get; set; }
        public IList<string> positions { get; set; }
    }
}