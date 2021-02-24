using Newtonsoft.Json;
using System.Collections.Generic;

namespace ByPassTheMovieAPI
{

    public class ResultTopRated
    {
        public int page { get; set; }
        public List<TopRatedResponse> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }

    public class TopRatedResponse
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("backdrop_path")]
        public string Backdrop_path { get; set; }

        [JsonProperty("genre_ids")]
        public int[] Genre_ids { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("original_language")]
        public string Original_language { get; set; }

        [JsonProperty("original_title")]
        public string Original_title { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("popularity")]
        public float Popularity { get; set; }

        [JsonProperty("poster_path")]
        public string Poster_path { get; set; }

        [JsonProperty("release_date")]
        public string Release_date { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public float Vote_average { get; set; }

        [JsonProperty("vote_count")]
        public int Vote_count { get; set; }
    }

}
