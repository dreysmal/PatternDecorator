namespace Decorator_professions
{
    public abstract class EntityDecorator : Entity
    {
        protected Entity entity;

        protected EntityDecorator(Entity entity_)
        {
            entity = entity_;
        }
    }
}
