using System.Collections;
using System.Collections.Generic;
using xyLOGIX.Api.Data.Iterables.Interfaces;

namespace xyLOGIX.Api.Data.Iterables
{
    public abstract class IterableBase<T> : IIterable<T> where T : class
    {
        /// <summary>Returns an enumerator that iterates through the collection.</summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public abstract IEnumerator<T> GetEnumerator();

        /// <summary>Returns an enumerator that iterates through a collection.</summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}