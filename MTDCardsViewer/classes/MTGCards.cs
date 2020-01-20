using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDCardsViewer.classes
{

    public class Ruling
    {

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ForeignName
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("flavor")]
        public string Flavor { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("multiverseid")]
        public int Multiverseid { get; set; }
    }

    public class Legality
    {

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("legality")]
        public string LegalityProp { get; set; }
    }

    public class Card
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("manaCost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public double Cmc { get; set; }

        [JsonProperty("colors")]
        public IList<string> Colors { get; set; }

        [JsonProperty("colorIdentity")]
        public IList<string> ColorIdentity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("supertypes")]
        public IList<string> Supertypes { get; set; }

        [JsonProperty("types")]
        public IList<string> Types { get; set; }

        [JsonProperty("subtypes")]
        public IList<string> Subtypes { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("multiverseid")]
        public int Multiverseid { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("rulings")]
        public IList<Ruling> Rulings { get; set; }

        [JsonProperty("foreignNames")]
        public IList<ForeignName> ForeignNames { get; set; }

        [JsonProperty("printings")]
        public IList<string> Printings { get; set; }

        [JsonProperty("originalText")]
        public string OriginalText { get; set; }

        [JsonProperty("originalType")]
        public string OriginalType { get; set; }

        [JsonProperty("legalities")]
        public IList<Legality> Legalities { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("flavor")]
        public string Flavor { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("toughness")]
        public string Toughness { get; set; }

        [JsonProperty("variations")]
        public IList<string> Variations { get; set; }
    }

    public class MTGCards
    {

        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }
    }
}