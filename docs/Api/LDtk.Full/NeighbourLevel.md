# NeighbourLevel class

Nearby level info

```csharp
public class NeighbourLevel
```

## Public Members

| name | description |
| --- | --- |
| [NeighbourLevel](NeighbourLevel/NeighbourLevel.md)() | The default constructor. |
| [Dir](NeighbourLevel/Dir.md) { get; set; } | A lowercase string tipping on the level location (`n`orth, `s`outh, `w`est, `e`ast). Since 1.4.0, this value can also be &lt; (neighbour depth is lower), &gt; (neighbour depth is greater) or `o` (levels overlap and share the same world depth). Since 1.5.3, this value can also be `nw`,`ne`,`sw` or `se` for levels only touching corners. |
| [LevelIid](NeighbourLevel/LevelIid.md) { get; set; } | Neighbour Instance Identifier |
| [LevelUid](NeighbourLevel/LevelUid.md) { get; set; } | WARNING: this deprecated value is no longer exported since version 1.2.0 Replaced by: `levelIid` |

## See Also

* namespace [LDtk.Full](../LDtkMonogame.md)

<!-- DO NOT EDIT: generated by xmldocmd for LDtkMonogame.dll -->
