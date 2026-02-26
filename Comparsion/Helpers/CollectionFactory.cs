using Comparsion.Models;

namespace Comparsion.Helpers
{
    public static class CollectionFactory
    {
        /// <summary>
        /// Generuje seřazené pole o dané velikosti
        /// </summary>
        /// <param name="size">počet hodnot</param>
        /// <returns>pole dat</returns>
        public static Element[] GenerateOrderedArray(long size)
        {
            Element[] data = new Element[size];
            for (long i = 0; i < size; i++)
            {
                data[i] = new Element { Value = i, OriginalPosition = i};
            }
            return data;
        }

        /// <summary>
        /// Generuje pole zcela náhodných hodnoz o dané velikosti a rozsahu
        /// </summary>
        /// <param name="size">počet hodnot</param>
        /// <param name="range">horní hranice rozsahu náhodných čísel</param>
        /// <returns>pole dat</returns>
        public static Element[] GenerateRandomArray(long size, int range)
        {
            Element[] data = new Element[size];
            for (long i = 0; i < size; i++)
            {
                data[i] = new Element { Value = Random.Shared.Next(range), OriginalPosition = i };
            }
            return data;
        }

        /// <summary>
        /// Generuje pole zamíchaných hodnot, nejprve je vygenerována kolekce dat o daném počtu hodnot rozdělených do skupin dané velikosti, pak tyto hodnoty zamíchá.
        /// </summary>
        /// <param name="size">počet hodnot</param>
        /// <param name="group">maximální velikost každé skupiny</param>
        /// <returns>pole dat</returns>
        public static Element[] GenerateShuffledArray(long size, int group = 1)
        {
            Element[] data = new Element[size];
            for (long i = 0; i < size / group + 1; i++)
            {
                for (int j = 0; j < group; j++)
                {
                    if (i * group + j < size)
                    {
                        data[i * group + j] = new Element { Value = j, OriginalPosition = i * group + j };
                    }           
                }             
            }
            data.Shuffle();
            for (long i = 0; i < size; i++)
            {
                data[i].OriginalPosition = i;
            }
            return data;
        }
    }
}