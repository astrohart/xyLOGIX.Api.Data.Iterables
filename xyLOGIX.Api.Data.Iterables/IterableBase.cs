using System;
using System.Collections;
using System.Collections.Generic;
using xyLOGIX.Api.Data.Iterables.Interfaces;
using xyLOGIX.Api.Data.Iterators.Interfaces;

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
        /// Reference to the iterator that we use to return for enumeration functionality.
        /// </summary>
        private IIterator<T> _iterator;

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<T> GetEnumerator()
            => _iterator;

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be
        /// used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        /// <summary>
        /// Returns an iterator, that implements
        /// <see
        ///     cref="T:xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}" />
        /// , that
        /// iterates through the collection.
        /// </summary>
        /// <returns>
        /// An iterator that can be used to iterate through the collection.
        /// </returns>
        /// <remarks>
        /// This method's implementation merely casts the result of the
        /// <see
        ///     cref="M:xyLOGIX.Api.Data.Iterables.IterableBase.GetEnumerator" />
        /// method to <see cref="T:xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}" />.
        /// </remarks>
        public IIterator<T> GetIterator()
            => (IIterator<T>) GetEnumerator();

        public IIterable<T> HavingIterator<T>(IIterator<T> iterator)
            where T : class
        {
            _iterator = iterator;

            return (IIterable<T>) this;
        }
    }
}