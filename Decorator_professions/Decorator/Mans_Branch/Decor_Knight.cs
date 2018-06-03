namespace Decorator_professions
{
    public class Decor_Knight : EntityDecorator
    {
        public Decor_Knight(Entity entity_) : base(entity_)
        {
            Atack = entity.Atack - 10;
            Speed = entity.Speed + 40;
            Health = entity.Health + 200;
            Armor = entity.Armor + 100;
        }
    }
}
