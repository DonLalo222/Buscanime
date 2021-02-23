using System;

namespace Buscanime.Repositories
{
    public class Api
    {
        private string apiPath = "https://api.jikan.moe/v3";

        public string GetApiPath()
        {
            return this.apiPath;
        }

    }
}