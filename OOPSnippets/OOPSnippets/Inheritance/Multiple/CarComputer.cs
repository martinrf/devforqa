using System;
using System.Collections.Generic;

namespace OOPSnippets.Inheritance.Multiple
{
    public class CarComputer : IHasMotor, IHasWindows, IAndroidServices, IHasDoors
    {
        public List<object> Windows { get; set; }

        public List<object> Doors { get; set; }

        public int Acelerar()
        {
            throw new NotImplementedException();
        }

        public int Desacelerar()
        {
            throw new NotImplementedException();
        }

        public bool? Call(string number)
        {
            throw new NotImplementedException();
        }

        public string GoogleIt(string query)
        {
            throw new NotImplementedException();
        }

        bool IHasWindows.Open(int window)
        {
            throw new NotImplementedException();
        }

        bool IHasDoors.Close(int door)
        {
            throw new NotImplementedException();
        }

        bool IHasDoors.Open(int door)
        {
            throw new NotImplementedException();
        }

        bool IHasWindows.Close(int window)
        {
            throw new NotImplementedException();
        }
    }
}
