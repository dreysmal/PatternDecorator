namespace Decorator_professions
{
    public class Decor_Elf_Kind_Mag : EntityDecorator
    {
        public Decor_Elf_Kind_Mag(Entity entity_) : base(entity_)
        {
            Atack = entity.Atack + 50;
            Speed = entity.Speed + 30;
            Health = entity.Health + 100;
            Armor = entity.Armor + 30;
        }
    }
}
