namespace OOPSnippets.ClassesAndObjects
{
    public static class StaticClass
    {
        private static int internalCounter;

        public static int GetCounter
        {
            get
            {
                return internalCounter++;
            }
        }
    }
}
