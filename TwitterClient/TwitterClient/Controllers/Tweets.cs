using Newtonsoft.Json;

namespace TwitterClient.Controllers
{
    public class Tweets
    {
        public  Tweet [] results;
    }

    public class Tweet
    {
        [JsonProperty("from_user")]
        public string username { get; set; }
        [JsonProperty("text")]
        public string tweettext { get; set; }
    }
}