using System;

namespace Decorator_professions
{
    public abstract class Entity
    {
        public Int32 Atack { get; set; }

        public Int32 Speed { get; set; }

        public Int32 Health { get; set; }

        public Int32 Armor { get; set; }
    }
}
