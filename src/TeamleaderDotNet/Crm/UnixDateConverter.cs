﻿using System;
using Newtonsoft.Json;
using TeamleaderDotNet.Utils;

namespace TeamleaderDotNet.Crm
{
    public class UnixDateConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            return reader.Value.ToString().UnixTimeToDateTime();
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}