using System;
using System.Threading;


namespace ExpWithCamera.logic
{
    public static class MyRandom
    {
        private static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() =>
        {
            int seed = DateTime.Now.Millisecond;
            return new Random(seed);
        });

        public static int Next()
        {
            return randomWrapper.Value.Next();
        }

        public static int Next(int maxValue)
        {
            return randomWrapper.Value.Next(maxValue);
        }

        public static int Next(int minValue, int maxValue)
        {
            return randomWrapper.Value.Next(minValue, maxValue);
        }
    }
}
