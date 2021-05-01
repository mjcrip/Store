namespace Store.Core.Interfaces
{
    public interface IEntityContext
    {
        ContextNames Name { get; }
    }
}

namespace Store.Core.Interfaces
{
    public enum ContextNames
    {
        Catelog
    }
}
