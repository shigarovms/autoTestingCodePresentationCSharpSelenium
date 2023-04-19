namespace a1qa_L2_UserInterface.Utilities
{
    internal static class RandomHelper
    {
        private static readonly Random random = new();

        internal static int GetRandomNumberFromRange(int n) => random.Next(n);
    }
}
