using Newtonsoft.Json;

namespace Sweets.Cakes.Models
{

    public class Cake
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("comment")]
        public string Comment { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
        [JsonProperty("yumFactor")]
        public int YumFactor { get; set; }


        public Cake(string id, string comment, string name, string imageUrl, int yumFactor)
        {
            this.Id = id;
            this.Comment = comment;
            this.Name = name;
            this.ImageUrl = imageUrl;
            this.YumFactor = yumFactor;
        }
    }
}
