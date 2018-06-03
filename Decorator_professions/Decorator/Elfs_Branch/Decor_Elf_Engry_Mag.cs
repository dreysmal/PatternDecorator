namespace Decorator_professions
{
    public class Decor_Elf_Engry_Mag : EntityDecorator
    {
        public Decor_Elf_Engry_Mag(Entity entity_) : base(entity_)
        {
            Atack = entity.Atack + 70;
            Speed = entity.Speed + 20;
            Health = entity.Health;
            Armor = entity.Armor;
        }
    }
}
