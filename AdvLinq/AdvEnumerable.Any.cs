using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>Determines asynchronously whether a sequence contains any elements.</summary>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to check for emptiness.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if the source sequence contains any elements; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static Task<bool> AnyAsync<TSource>(this IEnumerable<TSource> source) => Task.Run(() => source.Any());

        /// <summary>Determines asynchronously whether any element of a sequence satisfies a condition.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if any elements in the source sequence pass the test in the specified predicate; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
        public static Task<bool> AnyAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) => Task.Run(() => source.Any(predicate));
    }
}