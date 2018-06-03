namespace Decorator_professions
{
    public class Decor_SwordKeeper : EntityDecorator
    {
        public Decor_SwordKeeper(Entity entity_) : base(entity_)
        {
            Atack = entity.Atack +40;
            Speed = entity.Speed - 10;
            Health = entity.Health + 50;
            Armor = entity.Armor + 40;
        }
    }
}
