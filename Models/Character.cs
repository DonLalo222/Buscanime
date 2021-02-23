using System;
using System.Collections.Generic;

namespace Buscanime.Models
{
    public class Character
    {
        public int mal_id { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public IList<VoiceActor> voice_actors { get; set; }
    }
}