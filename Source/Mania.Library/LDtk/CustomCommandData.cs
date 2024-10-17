using System.Text.Json.Serialization;

namespace Mania.Library.LDtk;

public class CustomCommandData
{
    [JsonPropertyName("command")]
    public string Command { get; set; }

    /// <summary>
    /// Possible values: `Manual`, `AfterLoad`, `BeforeSave`, `AfterSave`
    /// </summary>
    [JsonPropertyName("when")]
    public WhenData When { get; set; }
}