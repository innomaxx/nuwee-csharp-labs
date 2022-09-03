
namespace MaxInno.NUWEE.Common
{
    public static class RandomUtils
    {
        public static int GetRandomInt(int from, int to)
        {
            var random = new Random();
            return GetRandomInt(from, to, random);
        }

        public static int GetRandomInt(int from, int to, Random random)
        {
            return random.Next(from, to + 1);
        }
    }
}