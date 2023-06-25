// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Triangle
    /// </summary>
    public partial class Triangle : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="equilateralTriangle"></param>
        /// <param name="triangleType">triangleType</param>
        [JsonConstructor]
        public Triangle(EquilateralTriangle equilateralTriangle, string triangleType)
        {
            EquilateralTriangle = equilateralTriangle;
            TriangleType = triangleType;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="isoscelesTriangle"></param>
        /// <param name="triangleType">triangleType</param>
        [JsonConstructor]
        public Triangle(IsoscelesTriangle isoscelesTriangle, string triangleType)
        {
            IsoscelesTriangle = isoscelesTriangle;
            TriangleType = triangleType;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="scaleneTriangle"></param>
        /// <param name="triangleType">triangleType</param>
        [JsonConstructor]
        public Triangle(ScaleneTriangle scaleneTriangle, string triangleType)
        {
            ScaleneTriangle = scaleneTriangle;
            TriangleType = triangleType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets EquilateralTriangle
        /// </summary>
        public EquilateralTriangle EquilateralTriangle { get; set; }

        /// <summary>
        /// Gets or Sets IsoscelesTriangle
        /// </summary>
        public IsoscelesTriangle IsoscelesTriangle { get; set; }

        /// <summary>
        /// Gets or Sets ScaleneTriangle
        /// </summary>
        public ScaleneTriangle ScaleneTriangle { get; set; }

        /// <summary>
        /// Gets or Sets TriangleType
        /// </summary>
        [JsonPropertyName("triangleType")]
        public string TriangleType { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Triangle {\n");
            sb.Append("  TriangleType: ").Append(TriangleType).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Triangle" />
    /// </summary>
    public class TriangleJsonConverter : JsonConverter<Triangle>
    {
        /// <summary>
        /// Deserializes json to <see cref="Triangle" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Triangle Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string triangleType = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "triangleType":
                            triangleType = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (triangleType == null)
                throw new ArgumentNullException(nameof(triangleType), "Property is required for class Triangle.");

            Utf8JsonReader equilateralTriangleReader = utf8JsonReader;
            if (Client.ClientUtils.TryDeserialize<EquilateralTriangle>(ref equilateralTriangleReader, jsonSerializerOptions, out EquilateralTriangle equilateralTriangle))
                return new Triangle(equilateralTriangle, triangleType);

            Utf8JsonReader isoscelesTriangleReader = utf8JsonReader;
            if (Client.ClientUtils.TryDeserialize<IsoscelesTriangle>(ref isoscelesTriangleReader, jsonSerializerOptions, out IsoscelesTriangle isoscelesTriangle))
                return new Triangle(isoscelesTriangle, triangleType);

            Utf8JsonReader scaleneTriangleReader = utf8JsonReader;
            if (Client.ClientUtils.TryDeserialize<ScaleneTriangle>(ref scaleneTriangleReader, jsonSerializerOptions, out ScaleneTriangle scaleneTriangle))
                return new Triangle(scaleneTriangle, triangleType);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="Triangle" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="triangle"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Triangle triangle, JsonSerializerOptions jsonSerializerOptions)
        {
            System.Text.Json.JsonSerializer.Serialize(writer, triangle.EquilateralTriangle, jsonSerializerOptions);

            System.Text.Json.JsonSerializer.Serialize(writer, triangle.IsoscelesTriangle, jsonSerializerOptions);

            System.Text.Json.JsonSerializer.Serialize(writer, triangle.ScaleneTriangle, jsonSerializerOptions);

            writer.WriteStartObject();

            writer.WriteString("triangleType", triangle.TriangleType);

            writer.WriteEndObject();
        }
    }
}
