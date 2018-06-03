namespace Decorator_professions
{
    public class Decor_Elf_Archer : EntityDecorator
    {
        public Decor_Elf_Archer(Entity entity_) : base(entity_)
        {
            Atack += entity.Atack + 20;
            Speed += entity.Speed + 10;
            Health += entity.Health + 50;
            Armor += entity.Armor - 10;
        }
    }
}
