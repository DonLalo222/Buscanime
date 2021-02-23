using System;
using System.Collections.Generic;

namespace Buscanime.Models
{
    public class AnimeDetail
    {
        public string request_hash { get; set; }
        public bool request_cached { get; set; }
        public int request_cache_expiry { get; set; }
        public int mal_id { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public string trailer_url { get; set; }
        public string title { get; set; }
        public string title_english { get; set; }
        public string title_japanese { get; set; }
        public IList<string> title_synonyms { get; set; }
        public string type { get; set; }
        public string source { get; set; }
        public int? episodes { get; set; }
        public string status { get; set; }
        public bool airing { get; set; }
        public Aired aired { get; set; }
        public string duration { get; set; }
        public string rating { get; set; }
        public double? score { get; set; }
        public int? scored_by { get; set; }
        public int? rank { get; set; }
        public int? popularity { get; set; }
        public int? members { get; set; }
        public int? favorites { get; set; }
        public string synopsis { get; set; }
        public string background { get; set; }
        public string premiered { get; set; }
        public string broadcast { get; set; }
        public Related related { get; set; }
        public IList<Producer> producers { get; set; }
        public IList<Licensor> licensors { get; set; }
        public IList<Studio> studios { get; set; }
        public IList<Genre> genres { get; set; }
        public IList<string> opening_themes { get; set; }
        public IList<string> ending_themes { get; set; }
    }
}