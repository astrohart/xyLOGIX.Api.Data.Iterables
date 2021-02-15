using System.Collections;
using System.Collections.Generic;
using xyLOGIX.Api.Data.Iterables.Interfaces;

namespace xyLOGIX.Api.Data.Iterables
{
    /// <summary>
    /// Serves as the common base for all REST API iterable objects.
    /// </summary>
    /// <typeparam name="T">
    /// Type of the element of the collection -- typically a JSON-deserialized
    /// class representing a single value in the REST API's data set.
    /// </typeparam>
    public abstract class IterableBase<T> : IIterable<T> where T : class
    {
        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        public abstract IEnumerator<T> GetEnumerator();

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be
        /// used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}