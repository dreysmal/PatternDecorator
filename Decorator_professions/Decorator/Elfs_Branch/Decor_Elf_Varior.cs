namespace Decorator_professions
{
    public class Decor_Elf_Varior : EntityDecorator
    {
        public Decor_Elf_Varior(Entity entity_) : base(entity_)
        {
            Atack = entity.Atack + 20;
            Speed = entity.Speed - 10;
            Health = entity.Health + 100;
            Armor = entity.Armor + 20;
        }
    }
}
