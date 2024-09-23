namespace Bank.Domain.Common.Model
{
    public abstract class AggregateRoot : Entity
    {
        // You can add common properties or methods for aggregate roots here
        // For example, a collection of child entities
        protected readonly List<Entity> _children = new List<Entity>();

        public IReadOnlyList<Entity> Children => _children.AsReadOnly();

        protected void AddChild(Entity child)
        {
            if (child is null)
                throw new ArgumentNullException(nameof(child));

            _children.Add(child);
        }

        public void RemoveChild(Entity child)
        {
            if (child is null)
                throw new ArgumentNullException(nameof(child));

            _children.Remove(child);
        }

        // Additional methods for business logic can be added here
    }
}