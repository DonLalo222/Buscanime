using System.Collections.Generic;

namespace Buscanime.Models
{
    public class QueryAnime
    {
        public string request_hash { get; set; }
        public bool request_cached { get; set; }
        public int request_cache_expiry { get; set; }
        public IList<Result> results { get; set; }
        public int last_page { get; set; }
    }
}
