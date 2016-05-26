using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace RuneScape_VoS_Notifier.Source
{
    public class TwitterHandler
    {
        private static string AccessTokenURL = "https://api.twitter.com/oauth2/token ";
        private static string TweetFeedURL = "https://api.twitter.com/1.1/statuses/user_timeline.json?count={0}&screen_name={1}&trim_user=1&exclude_replies=1";

        private static string UserName = "JagexClock";
        private static int TweetCount = 5;

        private static string OAuthConsumerKey = "Key";
        private static string OAuthConsumerSecret = "Secret";

        public async Task<IEnumerable<string>> GetTweets()
        {
            var accessToken = await GetAccessToken();

            var requestUserTimeline = new HttpRequestMessage(HttpMethod.Get, string.Format(TweetFeedURL, TweetCount, UserName));
            requestUserTimeline.Headers.Add("Authorization", "Bearer " + accessToken);

            var httpClient = new HttpClient();
            HttpResponseMessage responseUserTimeLine = await httpClient.SendAsync(requestUserTimeline);
            var serializer = new JavaScriptSerializer();
            dynamic json = serializer.Deserialize<object>(await responseUserTimeLine.Content.ReadAsStringAsync());

            var enumerableTweets = (json as IEnumerable<dynamic>);
            if (enumerableTweets == null)
            {
                return null;
            }
            return enumerableTweets.Select(t => (string)(t["text"].ToString()));
        }

        public async Task<string> GetAccessToken()
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, AccessTokenURL);
            var customerInfo = Convert.ToBase64String(new UTF8Encoding().GetBytes(OAuthConsumerKey + ":" + OAuthConsumerSecret));
            request.Headers.Add("Authorization", "Basic " + customerInfo);
            request.Content = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");

            HttpResponseMessage response = await httpClient.SendAsync(request);

            string json = await response.Content.ReadAsStringAsync();
            var serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(json);
            return item["access_token"];
        }
    }
}
