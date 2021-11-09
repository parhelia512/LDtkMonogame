#pragma warning disable CS1591
namespace LDtk.Generator
{
    public class LdtkCodeCustomizer
    {
        public virtual void CustomizeEntity(CompilationUnitClass entity, EntityDefinition ed, LdtkGeneratorContext ctx)
        {
            entity.Fields.Add(new CompilationUnitField("Uid", "long"));
            entity.Fields.Add(new CompilationUnitField("Identifier", "string"));
            entity.Fields.Add(new CompilationUnitField("Size", "Vector2"));
            entity.Fields.Add(new CompilationUnitField("Position", "Vector2"));
            entity.Fields.Add(new CompilationUnitField("Pivot", "Vector2"));
            entity.Fields.Add(new CompilationUnitField("Tile", "Rectangle"));
            entity.Fields.Add(new CompilationUnitField("Color", "Color"));
        }

        public virtual void CustomizeLevel(CompilationUnitClass level, LDtkWorld ldtkJson, LdtkGeneratorContext ctx)
        {
        }
    }
}
#pragma warning restore CS1591