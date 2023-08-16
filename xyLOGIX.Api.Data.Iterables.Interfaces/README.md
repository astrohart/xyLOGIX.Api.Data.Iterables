<a name='assembly'></a>
# xyLOGIX.Api.Data.Iterables.Interfaces

## Contents

- [IIterable\`1](#T-xyLOGIX-Api-Data-Iterables-Interfaces-IIterable`1 'xyLOGIX.Api.Data.Iterables.Interfaces.IIterable`1')
  - [GetIterator()](#M-xyLOGIX-Api-Data-Iterables-Interfaces-IIterable`1-GetIterator 'xyLOGIX.Api.Data.Iterables.Interfaces.IIterable`1.GetIterator')
  - [HavingIterator(iterator)](#M-xyLOGIX-Api-Data-Iterables-Interfaces-IIterable`1-HavingIterator-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{`0}- 'xyLOGIX.Api.Data.Iterables.Interfaces.IIterable`1.HavingIterator(xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{`0})')
- [Resources](#T-xyLOGIX-Api-Data-Iterables-Interfaces-Properties-Resources 'xyLOGIX.Api.Data.Iterables.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Api-Data-Iterables-Interfaces-Properties-Resources-Culture 'xyLOGIX.Api.Data.Iterables.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Api-Data-Iterables-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Api.Data.Iterables.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Api-Data-Iterables-Interfaces-IIterable`1'></a>
## IIterable\`1 `type`

##### Namespace

xyLOGIX.Api.Data.Iterables.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an iterable object
(the API data version of [IEnumerable{T}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{T}') . So why make this
separate interface/object tree? Because you need to then bolt this up to
a custom implementation that does not necessarily need to do all the
things an IEnumerable does, given the unique nature of paged API data.

<a name='M-xyLOGIX-Api-Data-Iterables-Interfaces-IIterable`1-GetIterator'></a>
### GetIterator() `method`

##### Summary

Returns an iterator, that implements [IIterator{T}](#T-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{T} 'xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}') , that
iterates through the collection.

##### Returns

An iterator that can be used to iterate through the collection.

##### Parameters

This method has no parameters.

##### Remarks

This method's implementation merely casts the result of the [GetEnumerator](#M-xyLOGIX-Api-Data-Iterables-IterableBase-GetEnumerator 'xyLOGIX.Api.Data.Iterables.IterableBase.GetEnumerator')
method to [IIterator{T}](#T-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{T} 'xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}').

<a name='M-xyLOGIX-Api-Data-Iterables-Interfaces-IIterable`1-HavingIterator-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{`0}-'></a>
### HavingIterator(iterator) `method`

##### Summary

Associates this iterable with an iterator. Basically, this sets up
the same relationship as exists between [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable') and [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator 'System.Collections.Generic.IEnumerator').

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iterator | [xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{\`0}](#T-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{`0} 'xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{`0}') | (Required.) Reference to an instance of an object that implements
the [IIterator{T}](#T-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{T} 'xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}')
interface that represents the iterator object that is to be
associated with this object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | Thrown if the required parameter, `iterator`, is
passed a `null` value. |

##### Remarks

Users may wonder why we are writing this method here as opposed to
using inversion of control by passing this in the constructor.



We have a factory in front of both these objects, and the objective
of using fluent methods instead is to avoid having to include a
whole bunch of NuGet packages in the factory module.

<a name='T-xyLOGIX-Api-Data-Iterables-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Api.Data.Iterables.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Api-Data-Iterables-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Api-Data-Iterables-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
