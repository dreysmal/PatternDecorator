using System;
namespace Decorator_professions
{
    public enum profession { MAN, MAN_VARIOR, MAN_SWORD, MAN_ARCHER, MAN_KNIGHT, ELF, ELF_VARIOR, ELF_MAG, ELF_ARCHER, ELF_ENGRY_MAG, ELF_KIND_MAG }
    public delegate void myVoidStringDelegate(profession str);
    interface Iprofessions
    {
        Int32 Atack { get; set; }
        Int32 Speed { get; set; }
        Int32 Health { get; set; }
        Int32 Armor { get; set; }

        event myVoidStringDelegate ManClicHandler;
        event myVoidStringDelegate ElfClicHandler;
    }
}
