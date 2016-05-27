using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RuneScape_VoS_Notifier.Source
{
    class CheckerThread
    {
        int hour;
        string prevVoS;
        bool updated;
        volatile bool exit;

        Thread thread;

        public CheckerThread()
        {
            hour = -1;
            prevVoS = null;
            updated = false;
            exit = false;

            thread = new Thread(this.Run);
            thread.Start();
        }

        public void Quit()
        {
            exit = true;
            thread.Abort();
        }

        public void Run()
        {
            while (!exit)
            {
                Thread.Sleep(5000);

                // check if we need updating
                if (hour != DateTime.Now.Hour)
                {
                    hour = DateTime.Now.Hour;
                    updated = false;
                }

                // if we do, update
                if (!updated)
                {
                    try
                    {
                        var twitter = new TwitterHandler();
                        IEnumerable<string> tweets = twitter.GetTweets().Result;
                        // find the voice tweet
                        string latestVoS = null;
                        foreach (var tweet in tweets)
                        {
                            if (!tweet.Contains("Voice of Seren"))
                                continue;
                            latestVoS = tweet;
                            break;
                        }
                        if (prevVoS == null || !prevVoS.Equals(latestVoS))
                        {
                            // new voice
                            string[] parts = latestVoS.Split(' ');
                            if (parts.Count() > 12)
                            {
                                prevVoS = latestVoS;
                                updated = true;
                                string clanOne = parts[9];
                                string clanTwo = parts[11];
                                FormMain.Instance.SetVoS(clanOne, clanTwo);
                                FormMain.Instance.ShowNotification(clanOne, clanTwo, latestVoS.Contains("Trahaearn"), hour);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // could not retrieve data, attempt again in 10 seconds
                    }
                }

                int minutes = 60 - DateTime.Now.Minute;
                FormMain.Instance.SetLabelText(minutes + " minute(s)");

                Thread.Sleep(5000);
            }
        }
    }
}
