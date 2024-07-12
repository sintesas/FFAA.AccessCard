using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using FFAA.AccessCard.Entity;

namespace FFAA.AccessCard.Services
{
    public static class CardService
    {
        public static CardInfo GetCard(string pUsername, string pUrl)
        {
            CardInfo cardInfo = null;
            string url = pUrl;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "?username=" + pUsername);
            request.Timeout = 3 * 60000;
            request.Method = "GET";
            request.ContentType = "application/json; charset=utf8";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                int statusCode = (int)response.StatusCode;
                if (statusCode == 500)
                {
                    cardInfo = null;
                }
                else
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    String body = reader.ReadToEnd();
                    cardInfo = JsonConvert.DeserializeObject<CardInfo>(body);
                }
            }

            return cardInfo;
        }
    }
}
