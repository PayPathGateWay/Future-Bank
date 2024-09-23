namespace Bank.Domain.Common.Model
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || GetType() != obj.GetType())
                return false;

            var entity = (Entity)obj;

            return Id == entity.Id;
        }

        public static bool operator ==(Entity? left, Entity? right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }

        public static bool operator !=(Entity? left, Entity? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GetType(), Id);
        }
    }
}