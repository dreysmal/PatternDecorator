namespace Decorator_professions
{
    public class Decor_Elf_Mag : EntityDecorator
    {
        public Decor_Elf_Mag(Entity entity_) : base(entity_)
        {
            Atack = entity.Atack + 10;
            Speed = entity.Speed + 10;
            Health = entity.Health - 50;
            Armor = entity.Armor + 10;
        }
    }
}
