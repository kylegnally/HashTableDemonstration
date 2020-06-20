using System;
using System.Collections.Generic;

namespace HashTableDemonstration
{
    class OurHashTable<T>
    {
        private KeyValuePair<int, T>[] _data;

        public OurHashTable()
        {
            _data = new KeyValuePair<int, T>[100];
        }

        /// <summary>
        /// Helper function to find the next index.  Returns an positive index or -1 is no valid index is available
        /// </summary>
        /// <param name="key">The object's key</param>
        /// <param name="hashCode">The object's hash value</param>
        /// <returns></returns>
        private int FindEmptyIndex(int key, int hashCode)
        {
            int end = _data.Length - 1;
            int index = hashCode;
            int pos = index + 1;

            end = _data.Length - 1;
            pos = index + 1;

            while (pos <= end && _data[pos].Key != 0)
                pos++;

            // if we are past the end, wrap the search
            if (pos > end)
            {
                pos = 0;
                end = index - 1;

                while (_data[pos].Key != 0 && pos <= end)
                    pos++;
            }

            if (pos > end)
                pos = -1;

            return pos;
        }

        /// <summary>
        /// Adds an element to the hashtable using the linear probing method to handle collisions
        /// </summary>
        /// <param name="element"></param>
        public void Add(int key, T element)
        {
            int index = element.GetHashCode();

            // Update the value if we have a key match (zero is an invalid key in this implementation)
            if (_data[index].Key == 0)
                _data[index] = new KeyValuePair<int, T>(key, element);
            else
            {
                int pos = FindEmptyIndex(key, index);
                if (pos != -1)
                    _data[pos] = new KeyValuePair<int, T>(key, element);
                else
                    throw new Exception("The table is full!");
            }
        }
    }
}
