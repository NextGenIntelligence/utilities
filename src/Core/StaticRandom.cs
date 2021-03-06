using System;

namespace Bearded.Utilities
{
    /// <summary>
    /// This static class offers a variety of pseudo random methods.
    /// The class is threadsafe and uses a different internal random object for each thread.
    /// Note that several of the methods are slightly biased for the sake of performance.
    /// </summary>
    /// <remarks>The actual implementations of the custom random methods can be found in RandomExtensions.</remarks>
    public static class StaticRandom
    {
        #region Threadsafe random
        [ThreadStatic]
        private static Random random;

        /// <summary>
        /// The thread safe instance of Random used by StaticRandom
        /// </summary>
        // is internal for use as default random in Linq.Extensions
        internal static Random Random { get { return random ?? (random = new Random()); } }

        /// <summary>
        /// Overrides the Random object for the calling thread by one with the given seed.
        /// </summary>
        /// <param name="seed">The seed</param>
        public static void SeedWith(int seed)
        {
            random = new Random(seed);
        }

        #endregion

        #region Int()

        /// <summary>
        /// Returns a random integer.
        /// </summary>
        public static int Int()
        {
            return Random.Next();
        }

        /// <summary>
        /// Returns a (biased) random integer in the interval [0, upper bound[.
        /// </summary>
        /// <param name="max">The exclusive upper bound.</param>
        public static int Int(int max)
        {
            return Random.Next(max);
        }

        /// <summary>
        /// Returns random (biased) integer in the interval [lower bound, upper bound[.
        /// </summary>
        /// <param name="min">The inclusive lower bound.</param>
        /// <param name="max">The exclusive upper bound.</param>
        public static int Int(int min, int max)
        {
            return Random.Next(min, max);
        }

        #endregion

        #region Long()

        /// <summary>
        /// Returns random (biased) long integer.
        /// </summary>
        /// <returns></returns>
        public static long Long()
        {
            return Random.NextLong();
        }

        /// <summary>
        /// Returns random (biased) long integer in the interval [0, upper bound[.
        /// </summary>
        /// <param name="max">The exclusive upper bound.</param>
        public static long Long(long max)
        {
            return Random.NextLong(max);
        }

        /// <summary>
        /// Returns random (biased) long integer in the interval [lower bound, upper bound[.
        /// </summary>
        /// <param name="min">The inclusive lower bound.</param>
        /// <param name="max">The exclusive upper bound.</param>
        public static long Long(long min, long max)
        {
            return Random.NextLong(min, max);
        }

        #endregion

        #region Double()

        /// <summary>
        /// Returns a random double in the interval [0, 1[.
        /// </summary>
        /// <returns></returns>
        public static double Double()
        {
            return Random.NextDouble();
        }

        /// <summary>
        /// Returns a random double in the interval [0, upper bound[.
        /// </summary>
        /// <param name="max">The exclusive upper bound.</param>
        public static double Double(double max)
        {
            return Random.NextDouble(max);
        }

        /// <summary>
        /// Returns a random double in the interval [lower bound, upper bound[.
        /// </summary>
        /// <param name="min">The inclusive lower bound.</param>
        /// <param name="max">The exclusive upper bound.</param>
        public static double Double(double min, double max)
        {
            return Random.NextDouble(min, max);
        }

        #endregion

        #region NormalDouble()

        /// <summary>
        /// Generates a random double using the standard normal distribution.
        /// </summary>
        public static double NormalDouble()
        {
            return Random.NormalDouble();
        }

        /// <summary>
        /// Generates a random double using the normal distribution with the given mean and deviation.
        /// </summary>
        /// <param name="mean">The expected value.</param>
        /// <param name="deviation">The standard deviation.</param>
        public static double NormalDouble(double mean, double deviation)
        {
            return Random.NormalDouble(mean, deviation);
        }

        #endregion

        #region Float()
        /// <summary>
        /// Returns random float in the interval [0, 1[.
        /// </summary>
        public static float Float()
        {
            return Random.NextFloat();
        }

        /// <summary>
        /// Returns a random float in the interval [0, upper bound[.
        /// </summary>
        /// <param name="max">The exclusive upper bound.</param>
        public static float Float(float max)
        {
            return Random.NextFloat(max);
        }

        /// <summary>
        /// Returns a random float in the interval [lower bound, upper bound[.
        /// </summary>
        /// <param name="min">The inclusive lower bound.</param>
        /// <param name="max">The exclusive upper bound.</param>
        public static float Float(float min, float max)
        {
            return Random.NextFloat(min, max);
        }
        #endregion

        #region NormalFloat()

        /// <summary>
        /// Generates a random float using the standard normal distribution.
        /// </summary>
        public static float NormalFloat()
        {
            return Random.NormalFloat();
        }

        /// <summary>
        /// Generates a random float using the normal distribution with the given mean and deviation.
        /// </summary>
        /// <param name="mean">The expected value.</param>
        /// <param name="deviation">The standard deviation.</param>
        public static float NormalFloat(float mean, float deviation)
        {
            return Random.NormalFloat(mean, deviation);
        }

        #endregion

        #region Various

        /// <summary>
        /// Returns -1 or 1 randomly.
        /// </summary>
        public static int Sign()
        {
            return Random.NextSign();
        }

        /// <summary>
        /// Returns a random boolean value.
        /// </summary>
        /// <param name="probability">The probability with which to return true.</param>
        /// <returns>Always returns true for probabilities greater or equal to 1 and false for probabilities less or equal to 0.</returns>
        public static bool Bool(double probability = 0.5)
        {
            return Random.NextBool(probability);
        }


        /// <summary>
        /// Returns an integer with a given expected value. Will always return either the floor or ceil of the given value.
        /// </summary>
        /// <param name="value">The expected value.</param>
        public static int Discretise(float value)
        {
            return Random.Discretise(value);
        }

        #endregion
    }
}
