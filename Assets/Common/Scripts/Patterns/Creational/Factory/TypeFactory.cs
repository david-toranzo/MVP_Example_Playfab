namespace Patterns.Factory
{
    public interface TypeFactory
    {
        public abstract IItemFactory GetItemFactory();
    }
}