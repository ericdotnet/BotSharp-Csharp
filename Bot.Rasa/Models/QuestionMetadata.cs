﻿using Bot.Rasa.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bot.Rasa.Models
{
    [JsonObject]
    public class QuestionMetadata
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("lang")]
        public string Language { get; set; }

        [JsonProperty("sessionId")]
        internal string SessionId { get; set; }

        [JsonProperty("entities")]
        public List<Entity> Entities { get; set; }
    }
}
