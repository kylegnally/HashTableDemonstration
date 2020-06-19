using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemonstration
{
    class OurHashTable<T>
    {
        private KeyValuePair<int, T>[] _data;

        public int Collisions { get; set; }
        public OurHashTable()
        {
            Collisions = 0;
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
            Collisions++;
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
        /// Finds an index given a key and a hash code.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="hashCode"></param>
        /// <returns>int</returns>
        private int FindIndex(int key, int hashCode)
        {
            int end = _data.Length - 1;
            int index = hashCode;
            int pos = index + 1;

            end = _data.Length - 1;
            pos = index + 1;

            if (_data[index].Key == key)
                return index;

            while (pos <= end && _data[pos].Key != key)
                pos++;

            // if we are past the end, wrap the search
            if (pos > end)
            {
                pos = 0;
                end = index - 1;

                while (_data[pos].Key != key && pos <= end)
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

        /// <summary>
        /// Returns the requested element from the HashTable by key.  Note that the element is requried to provide the Hash value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public T Get(int key, T element)
        {
            int pos = FindIndex(key, element.GetHashCode());

            if (pos == -1)
                return default(T);
            else
                return _data[pos].Value;
        }
    }
}
