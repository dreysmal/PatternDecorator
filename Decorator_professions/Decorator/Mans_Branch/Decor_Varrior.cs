namespace Decorator_professions
{
    class Decor_Varrior : EntityDecorator
    {
        public Decor_Varrior(Entity entity_) : base(entity_)
        {
            Atack = entity.Atack + 20;
            Speed = entity.Speed + 10;
            Health = entity.Health + 50;
            Armor = entity.Armor + 20;
        }
    }
}
