using System.Collections.Generic;

namespace OOPSnippets.Inheritance.Multiple
{
    public interface IHasWindows
    {
        List<object> Windows { get; set; } 
        bool Open(int window);
        bool Close(int window);
    }
}