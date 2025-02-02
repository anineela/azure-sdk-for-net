// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class TimeseriesDataPoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DateTimeUtc))
            {
                writer.WritePropertyName("dateTimeUTC");
                writer.WriteStringValue(DateTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteNumberValue(Value.Value);
            }
            writer.WriteEndObject();
        }

        internal static TimeseriesDataPoint DeserializeTimeseriesDataPoint(JsonElement element)
        {
            Optional<DateTimeOffset> dateTimeUtc = default;
            Optional<float> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTimeUTC"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
            }
            return new TimeseriesDataPoint(Optional.ToNullable(dateTimeUtc), Optional.ToNullable(value));
        }
    }
}
