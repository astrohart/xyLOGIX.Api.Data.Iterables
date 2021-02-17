using System.Collections.Generic;
using xyLOGIX.Api.Data.Iterators.Interfaces;

namespace xyLOGIX.Api.Data.Iterables.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an iterable object
    /// (the API data version of
    /// <see
    ///     cref="T:System.Collections.Generic.IEnumerable{T}" />
    /// . So why make this
    /// separate interface/object tree? Because you need to then bolt this up to
    /// a custom implementation that does not necessarily need to do all the
    /// things an IEnumerable does, given the unique nature of paged API data.
    /// </summary>
    public interface IIterable<T> : IEnumerable<T> where T : class
    {
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
        IIterator<T> GetIterator();
    }
}