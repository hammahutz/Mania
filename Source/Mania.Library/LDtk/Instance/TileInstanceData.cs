using System.Text.Json.Serialization;

namespace Mania.Library.LDtk.Instance;

public class TileInstanceData
{
        /// <summary>
        /// Alpha/opacity of the tile (0-1, defaults to 1)
        /// </summary>
        [JsonPropertyName("a")]
        public double A { get; set; }

        /// <summary>
        /// public data used by the editor.<br/>  For auto-layer tiles: `[ruleId, coordId]`.<br/>
        /// For tile-layer tiles: `[coordId]`.
        /// </summary>
        [JsonPropertyName("d")]
        public long[] D { get; set; }

        /// <summary>
        /// "Flip bits", a 2-bits integer to represent the mirror transformations of the tile.<br/>
        /// - Bit 0 = X flip<br/>   - Bit 1 = Y flip<br/>   Examples: f=0 (no flip), f=1 (X flip
        /// only), f=2 (Y flip only), f=3 (both flips)
        /// </summary>
        [JsonPropertyName("f")]
        public long F { get; set; }

        /// <summary>
        /// Pixel coordinates of the tile in the **layer** (`[x,y]` format). Don't forget optional
        /// layer offsets, if they exist!
        /// </summary>
        [JsonPropertyName("px")]
        public long[] Px { get; set; }

        /// <summary>
        /// Pixel coordinates of the tile in the **tileset** (`[x,y]` format)
        /// </summary>
        [JsonPropertyName("src")]
        public long[] Src { get; set; }

        /// <summary>
        /// The *Tile ID* in the corresponding tileset.
        /// </summary>
        [JsonPropertyName("t")]
        public long T { get; set; }
}
