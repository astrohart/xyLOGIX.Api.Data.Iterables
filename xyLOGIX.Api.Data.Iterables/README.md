<a name='assembly'></a>
# xyLOGIX.Api.Data.Iterables

## Contents

- [IterableBase\`1](#T-xyLOGIX-Api-Data-Iterables-IterableBase`1 'xyLOGIX.Api.Data.Iterables.IterableBase`1')
  - [_iterator](#F-xyLOGIX-Api-Data-Iterables-IterableBase`1-_iterator 'xyLOGIX.Api.Data.Iterables.IterableBase`1._iterator')
  - [AttachIterator(iterator)](#M-xyLOGIX-Api-Data-Iterables-IterableBase`1-AttachIterator-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{`0}- 'xyLOGIX.Api.Data.Iterables.IterableBase`1.AttachIterator(xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{`0})')
  - [GetEnumerator()](#M-xyLOGIX-Api-Data-Iterables-IterableBase`1-GetEnumerator 'xyLOGIX.Api.Data.Iterables.IterableBase`1.GetEnumerator')
  - [GetIterator()](#M-xyLOGIX-Api-Data-Iterables-IterableBase`1-GetIterator 'xyLOGIX.Api.Data.Iterables.IterableBase`1.GetIterator')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-xyLOGIX-Api-Data-Iterables-IterableBase`1-System#Collections#IEnumerable#GetEnumerator 'xyLOGIX.Api.Data.Iterables.IterableBase`1.System#Collections#IEnumerable#GetEnumerator')
- [Resources](#T-xyLOGIX-Api-Data-Iterables-Properties-Resources 'xyLOGIX.Api.Data.Iterables.Properties.Resources')
  - [Culture](#P-xyLOGIX-Api-Data-Iterables-Properties-Resources-Culture 'xyLOGIX.Api.Data.Iterables.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Api-Data-Iterables-Properties-Resources-ResourceManager 'xyLOGIX.Api.Data.Iterables.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Api-Data-Iterables-IterableBase`1'></a>
## IterableBase\`1 `type`

##### Namespace

xyLOGIX.Api.Data.Iterables

##### Summary

Serves as the common base for all REST API iterable objects.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the element of the collection -- typically a JSON-deserialized
class representing a single value in the REST API data set. |

<a name='F-xyLOGIX-Api-Data-Iterables-IterableBase`1-_iterator'></a>
### _iterator `constants`

##### Summary

Reference to the iterator that we use to return for enumeration functionality.

<a name='M-xyLOGIX-Api-Data-Iterables-IterableBase`1-AttachIterator-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{`0}-'></a>
### AttachIterator(iterator) `method`

##### Summary

Associates this iterable with an iterator. Basically, this sets up
the same relationship as exists between
[IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable')
and [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerator 'System.Collections.Generic.IEnumerator').

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iterator | [xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{\`0}](#T-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{`0} 'xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{`0}') | (Required.) Reference to an instance of an object that implements
the
[IIterator{T}](#T-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{T} 'xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}')
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

<a name='M-xyLOGIX-Api-Data-Iterables-IterableBase`1-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the collection.

##### Returns

An enumerator that can be used to iterate through the collection.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Api-Data-Iterables-IterableBase`1-GetIterator'></a>
### GetIterator() `method`

##### Summary

Returns an iterator, that implements
[IIterator{T}](#T-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{T} 'xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}')
, that
iterates through the collection.

##### Returns

An iterator that can be used to iterate through the collection.

##### Parameters

This method has no parameters.

##### Remarks

This method's implementation merely casts the result of the
[GetEnumerator](#M-xyLOGIX-Api-Data-Iterables-IterableBase-GetEnumerator 'xyLOGIX.Api.Data.Iterables.IterableBase.GetEnumerator')
method to [IIterator{T}](#T-xyLOGIX-Api-Data-Iterators-Interfaces-IIterator{T} 'xyLOGIX.Api.Data.Iterators.Interfaces.IIterator{T}').

<a name='M-xyLOGIX-Api-Data-Iterables-IterableBase`1-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through a collection.

##### Returns

An [IEnumerator](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerator 'System.Collections.IEnumerator') object that can be
used to iterate through the collection.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Api-Data-Iterables-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Api.Data.Iterables.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Api-Data-Iterables-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Api-Data-Iterables-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
