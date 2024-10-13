using System.Text.Json.Serialization;

namespace MonoLDtk.Shared.LDtkProject.Data.LDtkDefinitions;

internal class AutoLayerRuleGroupData
{
    [JsonPropertyName("active")]
    internal bool Active { get; set; }

    /// <summary>
    /// *This field was removed in 1.0.0 and should no longer be used.*
    /// </summary>
    [JsonPropertyName("collapsed")]
    internal bool? Collapsed { get; set; }

    [JsonPropertyName("isOptional")]
    internal bool IsOptional { get; set; }

    [JsonPropertyName("name")]
    internal string Name { get; set; }

    [JsonPropertyName("rules")]
    internal AutoLayerRuleDefinitionData[] Rules { get; set; }

    [JsonPropertyName("uid")]
    internal long Uid { get; set; }

    [JsonPropertyName("usesWizard")]
    internal bool UsesWizard { get; set; }
}
