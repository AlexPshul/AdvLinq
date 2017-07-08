using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>Flattens the multiple level sequence into a flat level. Same as performing an empty SelectMany</summary>
        /// <param name="source">A sequence of values to invoke a transform function on.</param>
        /// <typeparam name="TSource">The type of the inner elements of <paramref name="source" />.</typeparam>
        public static IEnumerable<TSource> Flatten<TSource>(this IEnumerable<IEnumerable<TSource>> source) => source.SelectMany(_ => _);

        /// <summary>
        /// Flattens the multiple level sequence into a flat level using a selector for each item. 
        /// Same as performing an SelectMany with a Select operator inside: source.SelectMany(inner => inner.Select(selector));
        /// </summary>
        /// <param name="source">A sequence of values to invoke a transform function on.</param>
        /// <param name="selector">The selector to perform on each item in the inner source.</param>
        /// <typeparam name="TSource">The type of the inner elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by <paramref name="selector" />.</typeparam>
        public static IEnumerable<TResult> Flatten<TSource, TResult>(this IEnumerable<IEnumerable<TSource>> source, Func<TSource, TResult> selector) => source.SelectMany(innerSequence => innerSequence.Select(selector));
    }
}