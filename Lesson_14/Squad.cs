using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lesson_14
{
    [Serializable]
    public class Squad
    {
        [JsonProperty ("squadName")]
        public string squadName { get; set; }

        [JsonProperty("homeTown")]
        public string homeTown { get; set; }

        [JsonProperty("formed")]
        public int formed { get; set; }

        [JsonProperty("secretBase")]
        public string secretBase { get; set; }

        [JsonProperty("active")]
        public bool active { get; set; }

        [JsonProperty("members")]
        public List<SuperHero> members { get; set; }

    }
}
