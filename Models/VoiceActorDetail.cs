using System;
using System.Collections.Generic;

namespace Buscanime.Models
{
    public class VoiceActorDetail
    {
        public string request_hash { get; set; }
        public bool request_cached { get; set; }
        public int request_cache_expiry { get; set; }
        public int mal_id { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public object website_url { get; set; }
        public string name { get; set; }
        public string given_name { get; set; }
        public string family_name { get; set; }
        public IList<string> alternate_names { get; set; }
        public DateTime? birthday { get; set; }
        public int member_favorites { get; set; }
        public string about { get; set; }
        public IList<object> voice_acting_roles { get; set; }
        public IList<AnimeStaffPosition> anime_staff_positions { get; set; }
        public IList<PublishedManga> published_manga { get; set; }
    }
}