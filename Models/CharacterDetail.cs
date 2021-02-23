using System;
using System.Collections.Generic;

namespace Buscanime.Models
{
    public class CharacterDetail
    {
        public string request_hash { get; set; }
        public bool request_cached { get; set; }
        public int request_cache_expiry { get; set; }
        public int mal_id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string name_kanji { get; set; }
        public IList<string> nicknames { get; set; }
        public string about { get; set; }
        public int member_favorites { get; set; }
        public string image_url { get; set; }
        public IList<Animeography> animeography { get; set; }
        public IList<Mangaography> mangaography { get; set; }
        public IList<VoiceActor> voice_actors { get; set; }
    }
}