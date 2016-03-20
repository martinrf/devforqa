using System;

namespace OOPSnippets.Inheritance.Multiple
{
    public class CarComputer : IHasMotor, IHasWindows, IAndroidServices
    {
        public int Acelerar()
        {
            throw new NotImplementedException();
        }

        public int Desacelerar()
        {
            throw new NotImplementedException();
        }

        public bool OpenWindow(int num)
        {
            throw new NotImplementedException();
        }

        public bool CloseWindow(int num)
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
    }
}
