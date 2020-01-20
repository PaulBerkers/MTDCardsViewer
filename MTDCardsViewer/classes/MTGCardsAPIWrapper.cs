using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.UI.Popups;
using System.Threading.Tasks;

namespace MTDCardsViewer.classes
{
    public class MTGCardsAPIWrapper
    {
        public static async Task<List<Card>> GetCards()
        {
            Uri request = new Uri(@"https://api.magicthegathering.io/v1/cards");

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "MTGCardsViewer");
            HttpResponseMessage respons = await client.GetAsync(request);
            if (respons.IsSuccessStatusCode == false)
            {
                MessageDialog md = new MessageDialog("Can't find cards!!");
                await md.ShowAsync();
                return null;
            }

            respons.EnsureSuccessStatusCode();

            MTGCards mc = await respons.Content.ReadAsAsync<MTGCards>();

            return mc.Cards;

        }
    }
}
