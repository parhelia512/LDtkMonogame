# WorldLayout Enum

[Home](../../README.md) &#x2022; [Fields](#fields)

**Namespace**: [LDtk](../README.md)

**Assembly**: LDtkMonogame\.dll

  
 : this field will move to the `worlds` array after the "multi\-worlds" update\. It will then be `null`\. You can enable the Multi\-worlds advanced project option to enable the change immediately\.  An enum that describes how levels are organized in this project \(ie\. linearly or in a 2D space\)\. Possible values: \<`null`\>, `Free`, `GridVania`, `LinearHorizontal`, `LinearVertical`, `null` 

```csharp
public enum WorldLayout
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) &#x2192; WorldLayout

## Fields

| Name | Value | Summary |
| ---- | ----- | ------- |
| Free | 0 |
| GridVania | 1 |
| LinearHorizontal | 2 |
| LinearVertical | 3 |

