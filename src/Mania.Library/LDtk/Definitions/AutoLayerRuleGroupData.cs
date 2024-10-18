using System.Text.Json.Serialization;

namespace Mania.Library.LDtk.Definitions;

public class AutoLayerRuleGroupData
{
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// *This field was removed in 1.0.0 and should no longer be used.*
    /// </summary>
    [JsonPropertyName("collapsed")]
    public bool? Collapsed { get; set; }

    [JsonPropertyName("isOptional")]
    public bool IsOptional { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("rules")]
    public AutoLayerRuleDefinitionData[] Rules { get; set; }

    [JsonPropertyName("uid")]
    public long Uid { get; set; }

    [JsonPropertyName("usesWizard")]
    public bool UsesWizard { get; set; }
}
