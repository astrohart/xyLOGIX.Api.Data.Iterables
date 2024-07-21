using PostSharp.Patterns.Threading;
using System.Collections.Generic;
using xyLOGIX.Api.Data.Iterators.Interfaces;

namespace xyLOGIX.Api.Data.Iterables.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an iterable
    /// object (the API data version of
    /// <see cref="T:System.Collections.Generic.IEnumerable{T}" /> . So why make this
    /// separate interface/object tree? Because you need to then bolt this up to a
    /// custom implementation that does not necessarily need to do all the things an
    /// IEnumerable does, given the unique nature of paged API data.
    /// </summary>
    [Synchronized]
    public interface IIterable<T> : IEnumerable<T> where T : class
    {
        /// <summary>
        /// Gets a value indicating whether an <b>Iterator</b> is attached.
        /// </summary>
        bool IteratorAttached { [DebuggerStepThrough] get; }

        /// <summary>
        /// Associates this iterable with an iterator. Basically, this sets up
        /// the same relationship as exists between
        /// <see cref="T:System.Collections.Generic.IEnumerable" /> and
        /// <see cref="T:System.Collections.Generic.IEnumerator" />.
        /// </summary>
        /// <param name="iterator">
        /// (Required.) Reference to an instance of an object that
        /// implements the
        /// <see cref="T:xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}" /> interface
        /// that represents the iterator object that is to be associated with this object.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this method,
        /// for fluent use.
        /// </returns>
        /// <exception cref="T:ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref name="iterator" />, is passed a <c>null</c> value.
        /// </exception>
        /// <remarks>
        /// Users may wonder why we are writing this method here as opposed to
        /// using inversion of control by passing this in the constructor.
        /// <para />
        /// We have a factory in front of both these objects, and the objective of using
        /// fluent methods instead is to avoid having to include a whole bunch of NuGet
        /// packages in the factory module.
        /// </remarks>
        IIterable<T> AttachIterator(IIterator<T> iterator);

        /// <summary>
        /// Returns an iterator, that implements
        /// <see cref="T:xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}" /> , that
        /// iterates through the collection.
        /// </summary>
        /// <returns> An iterator that can be used to iterate through the collection. </returns>
        /// <remarks>
        /// This method's implementation merely casts the result of the
        /// <see cref="M:xyLOGIX.Api.Data.Iterables.IterableBase.GetEnumerator" /> method
        /// to <see cref="T:xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}" />.
        /// </remarks>
        IIterator<T> GetIterator();
    }
}