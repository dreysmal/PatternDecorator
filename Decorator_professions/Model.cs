namespace Decorator_professions
{
    class Model
    {
        public Entity man = new Man();
        public Entity elf = new Elf();

        public void promote(profession profession)
        {
            switch (profession)
            {
                case profession.MAN:
                    man = new Man();
                    break;
                case profession.MAN_VARIOR:
                    man = new Decor_Varrior(man);
                    break;
                case profession.MAN_SWORD:
                    man = new Decor_SwordKeeper(man);
                    break;
                case profession.MAN_ARCHER:
                    man = new Decor_Archer(man);
                    break;
                case profession.MAN_KNIGHT:
                    man = new Decor_Knight(man);
                    break;
                case profession.ELF:
                    elf = new Elf();
                    break;
                case profession.ELF_VARIOR:
                    elf = new Decor_Elf_Varior(elf);
                    break;
                case profession.ELF_MAG:
                    elf = new Decor_Elf_Mag(elf);
                    break;
                case profession.ELF_ARCHER:
                    elf = new Decor_Elf_Archer(elf);
                    break;
                case profession.ELF_ENGRY_MAG:
                    elf = new Decor_Elf_Engry_Mag(elf);
                    break;
                case profession.ELF_KIND_MAG:
                    elf = new Decor_Elf_Kind_Mag(elf);
                    break;
                default:
                    break;
            }
        }
    }
}
