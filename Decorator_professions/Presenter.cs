namespace Decorator_professions
{
    class Presenter
    {
        private readonly Iprofessions iprofessions;
        private Model model = new Model();
        
        public Presenter(Iprofessions iprofessions)
        {
            this.iprofessions = iprofessions;
            iprofessions.ManClicHandler += manClickhandler;
            iprofessions.ElfClicHandler += elfCkickhandler;
        }

        public void manClickhandler(profession prof)
        {
            model.promote(prof);
            ManUpdate();
        }

        public void elfCkickhandler(profession prof)
        {
            model.promote(prof);
            ElfUpdate();
        }
        public void ManUpdate()
        {
            iprofessions.Atack = model.man.Atack;
            iprofessions.Speed = model.man.Speed;
            iprofessions.Health = model.man.Health;
            iprofessions.Armor = model.man.Armor;
        }
        public void ElfUpdate()
        {
            iprofessions.Atack = model.elf.Atack;
            iprofessions.Speed = model.elf.Speed;
            iprofessions.Health = model.elf.Health;
            iprofessions.Armor = model.elf.Armor;
        }
    }
}
