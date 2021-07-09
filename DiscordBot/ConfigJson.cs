using Newtonsoft.Json;

namespace Discord_Bot222
{
    public struct ConfigJson
    {
        [JsonProperty("token")]
       public string Token { get; private set; }
       [JsonProperty("prefix")]
       public string Prefix { get; private set; }
    }
}