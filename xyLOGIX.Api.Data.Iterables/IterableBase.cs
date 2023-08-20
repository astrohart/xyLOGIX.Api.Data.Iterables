using System;
using System.Collections;
using System.Collections.Generic;
using xyLOGIX.Api.Data.Iterables.Interfaces;
using xyLOGIX.Api.Data.Iterators.Interfaces;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Api.Data.Iterables
{
    /// <summary>
    /// Serves as the common base for all REST API iterable objects.
    /// </summary>
    /// <typeparam name="T">
    /// Type of the element of the collection -- typically a JSON-deserialized
    /// class representing a single value in the REST API data set.
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
        {
            IIterator<T> result;

            try
            {
                result = (IIterator<T>)GetEnumerator();

                result.Reset();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Associates this iterable with an iterator. Basically, this sets up
        /// the same relationship as exists between
        /// <see
        ///     cref="T:System.Collections.Generic.IEnumerable" />
        /// and <see cref="T:System.Collections.Generic.IEnumerator" />.
        /// </summary>
        /// <param name="iterator">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}" />
        /// interface that represents the iterator object that is to be
        /// associated with this object.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="iterator" />, is
        /// passed a <c>null</c> value.
        /// </exception>
        /// <remarks>
        /// Users may wonder why we are writing this method here as opposed to
        /// using inversion of control by passing this in the constructor.
        /// <para />
        /// We have a factory in front of both these objects, and the objective
        /// of using fluent methods instead is to avoid having to include a
        /// whole bunch of NuGet packages in the factory module.
        /// </remarks>
        public IIterable<T> HavingIterator(IIterator<T> iterator)
        {
            _iterator = iterator;

            return this;
        }
    }
}