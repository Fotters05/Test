using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace tester_wpf
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Enumm
    {
        vop1,
        vop2,
        vop3
    }
}