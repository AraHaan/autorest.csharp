﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AutoRest.CSharp.Common.Input
{
    internal class TypeSpecInputDurationTypeConverter : JsonConverter<InputDurationType>
    {
        private readonly TypeSpecReferenceHandler _referenceHandler;
        public TypeSpecInputDurationTypeConverter(TypeSpecReferenceHandler referenceHandler)
        {
            _referenceHandler = referenceHandler;
        }

        public override InputDurationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
           => reader.ReadReferenceAndResolve<InputDurationType>(_referenceHandler.CurrentResolver) ?? CreateDurationType(ref reader, null, options, _referenceHandler.CurrentResolver);

        public override void Write(Utf8JsonWriter writer, InputDurationType value, JsonSerializerOptions options)
            => throw new NotSupportedException("Writing not supported");

        public static InputDurationType CreateDurationType(ref Utf8JsonReader reader, string? id, JsonSerializerOptions options, ReferenceResolver resolver)
        {
            var isFirstProperty = id == null;
            string? encode = null;
            InputType? type = null;
            IReadOnlyList<InputDecoratorInfo>? decorators = null;

            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadString(nameof(InputDurationType.Encode), ref encode)
                    || reader.TryReadWithConverter(nameof(InputDurationType.WireType), options, ref type)
                    || reader.TryReadWithConverter(nameof(InputDurationType.Decorators), options, ref decorators);

                if (!isKnownProperty)
                {
                    reader.SkipProperty();
                }
            }

            if (type is not InputPrimitiveType wireType)
            {
                throw new JsonException("The wireType of a Duration type must be a primitive type");
            }

            encode = encode ?? throw new JsonException("Duration type must have encoding");

            var dateTimeType = Enum.TryParse<DurationKnownEncoding>(encode, ignoreCase: true, out var encodeKind)
                ? new InputDurationType(encodeKind, wireType) { Decorators = decorators ?? Array.Empty<InputDecoratorInfo>() }
                : throw new JsonException($"Encoding of Duration type {encode} is unknown.");

            if (id != null)
            {
                resolver.AddReference(id, dateTimeType);
            }
            return dateTimeType;
        }
    }
}
