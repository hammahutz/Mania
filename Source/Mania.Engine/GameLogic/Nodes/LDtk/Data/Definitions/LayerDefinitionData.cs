using System.Text.Json.Serialization;

namespace Mania.Engine.GameLogic.Nodes.LDtk.Data.Definitions;

internal class LayerDefinitionData
{
        /// <summary>
        /// Type of the layer (*IntGrid, Entities, Tiles or AutoLayer*)
        /// </summary>
        [JsonPropertyName("__type")]
        internal string Type { get; set; }

        /// <summary>
        /// Contains all the auto-layer rule definitions.
        /// </summary>
        [JsonPropertyName("autoRuleGroups")]
        internal AutoLayerRuleGroupData[] AutoRuleGroups { get; set; }

        [JsonPropertyName("autoSourceLayerDefUid")]
        internal long? AutoSourceLayerDefUid { get; set; }

        /// <summary>
        /// **WARNING**: this deprecated value is no longer exported since version 1.2.0  Replaced
        /// by: `tilesetDefUid`
        /// </summary>
        [JsonPropertyName("autoTilesetDefUid")]
        internal long? AutoTilesetDefUid { get; set; }

        /// <summary>
        /// Allow editor selections when the layer is not currently active.
        /// </summary>
        [JsonPropertyName("canSelectWhenInactive")]
        internal bool CanSelectWhenInactive { get; set; }

        /// <summary>
        /// Opacity of the layer (0 to 1.0)
        /// </summary>
        [JsonPropertyName("displayOpacity")]
        internal double DisplayOpacity { get; set; }

        /// <summary>
        /// User defined documentation for this element to provide help/tips to level designers.
        /// </summary>
        [JsonPropertyName("doc")]
        internal string Doc { get; set; }

        /// <summary>
        /// An array of tags to forbid some Entities in this layer
        /// </summary>
        [JsonPropertyName("excludedTags")]
        internal string[] ExcludedTags { get; set; }

        /// <summary>
        /// Width and height of the grid in pixels
        /// </summary>
        [JsonPropertyName("gridSize")]
        internal long GridSize { get; set; }

        /// <summary>
        /// Height of the optional "guide" grid in pixels
        /// </summary>
        [JsonPropertyName("guideGridHei")]
        internal long GuideGridHei { get; set; }

        /// <summary>
        /// Width of the optional "guide" grid in pixels
        /// </summary>
        [JsonPropertyName("guideGridWid")]
        internal long GuideGridWid { get; set; }

        [JsonPropertyName("hideFieldsWhenInactive")]
        internal bool HideFieldsWhenInactive { get; set; }

        /// <summary>
        /// Hide the layer from the list on the side of the editor view.
        /// </summary>
        [JsonPropertyName("hideInList")]
        internal bool HideInList { get; set; }

        /// <summary>
        /// User defined unique identifier
        /// </summary>
        [JsonPropertyName("identifier")]
        internal string Identifier { get; set; }

        /// <summary>
        /// Alpha of this layer when it is not the active one.
        /// </summary>
        [JsonPropertyName("inactiveOpacity")]
        internal double InactiveOpacity { get; set; }

        /// <summary>
        /// An array that defines extra optional info for each IntGrid value.<br/>  WARNING: the
        /// array order is not related to actual IntGrid values! As user can re-order IntGrid values
        /// freely, you may value "2" before value "1" in this array.
        /// </summary>
        [JsonPropertyName("intGridValues")]
        internal IntGridValueDefinitionData[] IntGridValues { get; set; }

        /// <summary>
        /// Parallax horizontal factor (from -1 to 1, defaults to 0) which affects the scrolling
        /// speed of this layer, creating a fake 3D (parallax) effect.
        /// </summary>
        [JsonPropertyName("parallaxFactorX")]
        internal double ParallaxFactorX { get; set; }

        /// <summary>
        /// Parallax vertical factor (from -1 to 1, defaults to 0) which affects the scrolling speed
        /// of this layer, creating a fake 3D (parallax) effect.
        /// </summary>
        [JsonPropertyName("parallaxFactorY")]
        internal double ParallaxFactorY { get; set; }

        /// <summary>
        /// If true (default), a layer with a parallax factor will also be scaled up/down accordingly.
        /// </summary>
        [JsonPropertyName("parallaxScaling")]
        internal bool ParallaxScaling { get; set; }

        /// <summary>
        /// X offset of the layer, in pixels (IMPORTANT: this should be added to the `LayerInstance`
        /// optional offset)
        /// </summary>
        [JsonPropertyName("pxOffsetX")]
        internal long PxOffsetX { get; set; }

        /// <summary>
        /// Y offset of the layer, in pixels (IMPORTANT: this should be added to the `LayerInstance`
        /// optional offset)
        /// </summary>
        [JsonPropertyName("pxOffsetY")]
        internal long PxOffsetY { get; set; }

        /// <summary>
        /// If TRUE, the content of this layer will be used when rendering levels in a simplified way
        /// for the world view
        /// </summary>
        [JsonPropertyName("renderInWorldView")]
        internal bool RenderInWorldView { get; set; }

        /// <summary>
        /// An array of tags to filter Entities that can be added to this layer
        /// </summary>
        [JsonPropertyName("requiredTags")]
        internal string[] RequiredTags { get; set; }

        /// <summary>
        /// If the tiles are smaller or larger than the layer grid, the pivot value will be used to
        /// position the tile relatively its grid cell.
        /// </summary>
        [JsonPropertyName("tilePivotX")]
        internal double TilePivotX { get; set; }

        /// <summary>
        /// If the tiles are smaller or larger than the layer grid, the pivot value will be used to
        /// position the tile relatively its grid cell.
        /// </summary>
        [JsonPropertyName("tilePivotY")]
        internal double TilePivotY { get; set; }

        /// <summary>
        /// Reference to the default Tileset UID being used by this layer definition.<br/>
        /// **WARNING**: some layer *instances* might use a different tileset. So most of the time,
        /// you should probably use the `__tilesetDefUid` value found in layer instances.<br/>  Note:
        /// since version 1.0.0, the old `autoTilesetDefUid` was removed and merged into this value.
        /// </summary>
        [JsonPropertyName("tilesetDefUid")]
        internal long? TilesetDefUid { get; set; }

        /// <summary>
        /// Type of the layer as Haxe Enum Possible values: `IntGrid`, `Entities`, `Tiles`,
        /// `AutoLayer`
        /// </summary>
        [JsonPropertyName("type")]
        internal TypeEnumData LayerDefinitionType { get; set; }

        /// <summary>
        /// User defined color for the UI
        /// </summary>
        [JsonPropertyName("uiColor")]
        internal string UiColor { get; set; }

        /// <summary>
        /// Unique Int identifier
        /// </summary>
        [JsonPropertyName("uid")]
        internal long Uid { get; set; }
}
