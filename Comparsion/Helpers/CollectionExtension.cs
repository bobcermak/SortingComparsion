namespace Comparsion.Helpers
{
    internal static class CollectionExtension
    {
        /// <summary>
        /// Zamíchání kolekce hodnot
        /// </summary>
        /// <typeparam name="T">typ dato v poli</typeparam>
        /// <param name="array">pole hodnot</param>
        public static void Shuffle<T>(this T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                long k = Random.Shared.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
