using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    [Serializable]
    public class SuperHero
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("age")]
        public int age { get; set; }

        [JsonProperty("secretIdentity")]
        public string secretIdentity { get; set; }

        [JsonProperty("powers")]
        public List<string> powers { get; set; }
    }
}
