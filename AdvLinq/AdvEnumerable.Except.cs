using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>Produces the set difference of two sequences by using the default equality comparer to compare values.</summary>
        /// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements that are not also in <paramref name="second" /> will be returned.</param>
        /// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence.</param>
        /// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
        /// <returns>A sequence that contains the set difference of the elements of two sequences.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="first" /> or <paramref name="second" /> is null.</exception>
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, params TSource[] second) => Enumerable.Except(first, second);

        /// <summary>Produces the set difference of two sequences by using the specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare values.</summary>
        /// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements that are not also in <paramref name="second" /> will be returned.</param>
        /// <param name="comparer">An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare values.</param>
        /// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence.</param>
        /// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
        /// <returns>A sequence that contains the set difference of the elements of two sequences.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="first" /> or <paramref name="second" /> is null.</exception>
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEqualityComparer<TSource> comparer, params TSource[] second) => first.Except(second, comparer);
    }
}