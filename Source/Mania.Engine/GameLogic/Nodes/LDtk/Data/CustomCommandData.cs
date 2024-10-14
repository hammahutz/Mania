using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data;

internal class CustomCommandData
{
    [JsonPropertyName("command")]
    internal string Command { get; set; }

    /// <summary>
    /// Possible values: `Manual`, `AfterLoad`, `BeforeSave`, `AfterSave`
    /// </summary>
    [JsonPropertyName("when")]
    internal WhenData When { get; set; }
}