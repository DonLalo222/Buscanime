using System;
using System.Collections.Generic;

namespace Buscanime.Models
{
    public class QueryVideo
    {
        public string request_hash { get; set; }
        public bool request_cached { get; set; }
        public int request_cache_expiry { get; set; }
        public IList<Promo> promo { get; set; }
        public IList<Episode> episodes { get; set; }
    }
}