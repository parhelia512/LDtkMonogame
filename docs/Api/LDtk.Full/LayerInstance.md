# LayerInstance class

Layer instance

```csharp
public class LayerInstance
```

## Public Members

| name | description |
| --- | --- |
| [LayerInstance](LayerInstance/LayerInstance.md)() | The default constructor. |
| [AutoLayerTiles](LayerInstance/AutoLayerTiles.md) { get; set; } | An array containing all tiles generated by Auto-layer rules. The array is already sorted in display order (ie. 1st tile is beneath 2nd, which is beneath 3rd etc.). Note: if multiple tiles are stacked in the same cell as the result of different rules, all tiles behind opaque ones will be discarded. |
| [EntityInstances](LayerInstance/EntityInstances.md) { get; set; } | EntityInstances |
| [GridTiles](LayerInstance/GridTiles.md) { get; set; } | GridTiles |
| [Iid](LayerInstance/Iid.md) { get; set; } | Unique layer instance identifier |
| [IntGrid](LayerInstance/IntGrid.md) { get; set; } | WARNING: this deprecated value is no longer exported since version 1.0.0 Replaced by: `intGridCsv` |
| [IntGridCsv](LayerInstance/IntGridCsv.md) { get; set; } | A list of all values in the IntGrid layer, stored in CSV format (Comma Separated Values). Order is from left to right, and top to bottom (ie. first row from left to right, followed by second row, etc).`0` means "empty cell" and IntGrid values start at 1. The array size is `__cWid` x `__cHei` cells. |
| [LayerDefUid](LayerInstance/LayerDefUid.md) { get; set; } | Reference the Layer definition UID |
| [LevelId](LayerInstance/LevelId.md) { get; set; } | Reference to the UID of the level containing this layer instance |
| [OptionalRules](LayerInstance/OptionalRules.md) { get; set; } | An Array containing the UIDs of optional rules that were enabled in this specific layer instance. |
| [OverrideTilesetUid](LayerInstance/OverrideTilesetUid.md) { get; set; } | This layer can use another tileset by overriding the tileset UID here. |
| [PxOffsetX](LayerInstance/PxOffsetX.md) { get; set; } | X offset in pixels to render this layer, usually 0 (IMPORTANT: this should be added to the `LayerDef` optional offset, so you should probably prefer using `__pxTotalOffsetX` which contains the total offset value) |
| [PxOffsetY](LayerInstance/PxOffsetY.md) { get; set; } | Y offset in pixels to render this layer, usually 0 (IMPORTANT: this should be added to the `LayerDef` optional offset, so you should probably prefer using `__pxTotalOffsetX` which contains the total offset value) |
| [Seed](LayerInstance/Seed.md) { get; set; } | Random seed used for Auto-Layers rendering |
| [Visible](LayerInstance/Visible.md) { get; set; } | Layer instance visibility |
| [_CHei](LayerInstance/_CHei.md) { get; set; } | Grid-based height |
| [_CWid](LayerInstance/_CWid.md) { get; set; } | Grid-based width |
| [_GridSize](LayerInstance/_GridSize.md) { get; set; } | Grid size |
| [_Identifier](LayerInstance/_Identifier.md) { get; set; } | Layer definition identifier |
| [_Opacity](LayerInstance/_Opacity.md) { get; set; } | Layer opacity as Float [0-1] |
| [_PxTotalOffsetX](LayerInstance/_PxTotalOffsetX.md) { get; set; } | Total layer X pixel offset, including both instance and definition offsets. |
| [_PxTotalOffsetY](LayerInstance/_PxTotalOffsetY.md) { get; set; } | Total layer Y pixel offset, including both instance and definition offsets. |
| [_TilesetDefUid](LayerInstance/_TilesetDefUid.md) { get; set; } | The definition UID of corresponding Tileset, if any. |
| [_TilesetRelPath](LayerInstance/_TilesetRelPath.md) { get; set; } | The relative path to corresponding Tileset, if any. |
| [_Type](LayerInstance/_Type.md) { get; set; } | Layer type (possible values: IntGrid, Entities, Tiles or AutoLayer) |

## See Also

* namespace [LDtk.Full](../LDtkMonogame.md)

<!-- DO NOT EDIT: generated by xmldocmd for LDtkMonogame.dll -->
