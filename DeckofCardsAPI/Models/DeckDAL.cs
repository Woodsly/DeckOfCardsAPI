using Newtonsoft.Json;
using System.Net;

namespace DeckofCardsAPI.Models
{
    public class DeckDAL
    {
        public DeckModel GetDeck() //adjust method name
        {
            //adjust api url 
            //api url
            string key = "9ge6z09enip2"; //this should be hidden
            string url = $"https://deckofcardsapi.com/api/deck/{key}/draw/?count=5";

            //setup request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //save response data
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust return
            //convert JSON to a C# object
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(JSON);
            return result;
        }
        public void ShuffleCards()
        {
            string key = "9ge6z09enip2";
            string url = $"https://deckofcardsapi.com/api/deck/{key}/shuffle/";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }

    }
}
