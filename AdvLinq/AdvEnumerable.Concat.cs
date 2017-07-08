using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>Concatenates multiple sequences.</summary>
        /// <param name="first">The first sequence to concatenate.</param>
        /// <param name="others">The sequences to concatenate to the first sequence.</param>
        /// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the concatenated elements of all the input sequences.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="first" /> or <paramref name="others" /> is null.</exception>
        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, params IEnumerable<TSource>[] others) => others.Aggregate(first, (one, two) => one.Concat(two));

        /// <summary>Concatenates multiple sequences.</summary>
        /// <param name="sequences">The sequences to concatenate to the first sequence.</param>
        /// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the concatenated elements of all the input sequences.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="sequences" /> is null.</exception>
        public static IEnumerable<TSource> Concat<TSource>(params IEnumerable<TSource>[] sequences) => sequences.Aggregate((one, two) => one.Concat(two));
    }
}