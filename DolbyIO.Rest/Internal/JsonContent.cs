using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace DolbyIO.Rest;

// From https://gist.github.com/lenkan/db28050fe8653890ac93e9f2ace7ba03
public class JsonContent : StringContent
{
    public JsonContent(string s) : base(s, Encoding.UTF8, "application/json")
    { }

    public JsonContent(object o) : this(JsonConvert.SerializeObject(o))
    { }
}
