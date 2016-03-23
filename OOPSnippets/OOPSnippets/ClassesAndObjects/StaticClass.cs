namespace OOPSnippets.ClassesAndObjects
{
    public static class StaticClass
    {
        private static int _internalCounter;

        public static int GetCounter
        {
            get
            {
                return _internalCounter++;
            }
        }
    }
}
