// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ProcessorNodeBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ProcessorNodeBase DeserializeProcessorNodeBase(JsonElement element)
        {
            if (element.TryGetProperty("@type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.VideoAnalyzer.CognitiveServicesVisionProcessor": return CognitiveServicesVisionProcessor.DeserializeCognitiveServicesVisionProcessor(element);
                    case "#Microsoft.VideoAnalyzer.ExtensionProcessorBase": return ExtensionProcessorBase.DeserializeExtensionProcessorBase(element);
                    case "#Microsoft.VideoAnalyzer.GrpcExtension": return GrpcExtension.DeserializeGrpcExtension(element);
                    case "#Microsoft.VideoAnalyzer.HttpExtension": return HttpExtension.DeserializeHttpExtension(element);
                    case "#Microsoft.VideoAnalyzer.LineCrossingProcessor": return LineCrossingProcessor.DeserializeLineCrossingProcessor(element);
                    case "#Microsoft.VideoAnalyzer.MotionDetectionProcessor": return MotionDetectionProcessor.DeserializeMotionDetectionProcessor(element);
                    case "#Microsoft.VideoAnalyzer.ObjectTrackingProcessor": return ObjectTrackingProcessor.DeserializeObjectTrackingProcessor(element);
                    case "#Microsoft.VideoAnalyzer.SignalGateProcessor": return SignalGateProcessor.DeserializeSignalGateProcessor(element);
                }
            }
            string type = default;
            string name = default;
            IList<NodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new ProcessorNodeBase(type, name, inputs);
        }
    }
}
