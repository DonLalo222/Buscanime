using System;
using System.Collections.Generic;

namespace Buscanime.Models
{
    public class QueryCharacterStaff
    {
        public string request_hash { get; set; }
        public bool request_cached { get; set; }
        public int request_cache_expiry { get; set; }
        public IList<Character> characters { get; set; }
        public IList<Staff> staff { get; set; }
    }
}