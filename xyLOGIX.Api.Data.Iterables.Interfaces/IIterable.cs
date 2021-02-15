using System.Collections.Generic;

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
    public interface IIterable<out T> : IEnumerable<T> where T : class { }
}