using System.Collections.Generic;

namespace OOPSnippets.Inheritance.Multiple
{
    public interface IHasDoors
    {
        List<object> Doors { get; set; } 
        bool Open(int door);
        bool Close(int door);
    }
}