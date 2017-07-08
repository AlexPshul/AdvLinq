using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>Creates a <see cref="T:System.Collections.Generic.Dictionary`2" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> asynchronously according to a specified key selector function.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.Dictionary`2" /> from.</param>
        /// <param name="keySelector">A function to extract a key from each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
        /// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2" /> that contains keys and values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="keySelector" /> is null.-or-<paramref name="keySelector" /> produces a key that is null.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="keySelector" /> produces duplicate keys for two elements.</exception>
        public static Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
            => Task.Run(() => source.ToDictionary(keySelector));

        /// <summary>Creates a <see cref="T:System.Collections.Generic.Dictionary`2" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> asynchronously according to a specified key selector function and key comparer.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.Dictionary`2" /> from.</param>
        /// <param name="keySelector">A function to extract a key from each element.</param>
        /// <param name="comparer">An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare keys.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TKey">The type of the keys returned by <paramref name="keySelector" />.</typeparam>
        /// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2" /> that contains keys and values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="keySelector" /> is null.-or-<paramref name="keySelector" /> produces a key that is null.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="keySelector" /> produces duplicate keys for two elements.</exception>
        public static Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
            => Task.Run(() => source.ToDictionary(keySelector, comparer));

        /// <summary>Creates a <see cref="T:System.Collections.Generic.Dictionary`2" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> asynchronously according to specified key selector and element selector functions.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.Dictionary`2" /> from.</param>
        /// <param name="keySelector">A function to extract a key from each element.</param>
        /// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
        /// <typeparam name="TElement">The type of the value returned by <paramref name="elementSelector" />.</typeparam>
        /// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2" /> that contains values of type <typeparamref name="TElement" /> selected from the input sequence.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="keySelector" /> or <paramref name="elementSelector" /> is null.-or-<paramref name="keySelector" /> produces a key that is null.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="keySelector" /> produces duplicate keys for two elements.</exception>
        public static Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
            => Task.Run(() => source.ToDictionary(keySelector, elementSelector));

        /// <summary>Creates a <see cref="T:System.Collections.Generic.Dictionary`2" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> asynchronously according to a specified key selector function, a comparer, and an element selector function.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.Dictionary`2" /> from.</param>
        /// <param name="keySelector">A function to extract a key from each element.</param>
        /// <param name="elementSelector">A transform function to produce a result element value from each element.</param>
        /// <param name="comparer">An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare keys.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
        /// <typeparam name="TElement">The type of the value returned by <paramref name="elementSelector" />.</typeparam>
        /// <returns>A <see cref="T:System.Collections.Generic.Dictionary`2" /> that contains values of type <typeparamref name="TElement" /> selected from the input sequence.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="keySelector" /> or <paramref name="elementSelector" /> is null.-or-<paramref name="keySelector" /> produces a key that is null.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="keySelector" /> produces duplicate keys for two elements.</exception>
        public static Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
            => Task.Run(() => source.ToDictionary(keySelector, elementSelector, comparer));

        /// <summary>Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Collections.Generic.IEnumerable`1" /> asynchronously.</summary>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create a <see cref="T:System.Collections.Generic.List`1" /> from.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>A <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static Task<List<TSource>> ToListAsync<TSource>(this IEnumerable<TSource> source) => Task.Run(() => source.ToList());

        /// <summary>Creates an array from a <see cref="T:System.Collections.Generic.IEnumerable`1" /> asynchronously.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create an array from.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>An array that contains the elements from the input sequence.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static Task<TSource[]> ToArrayAsync<TSource>(this IEnumerable<TSource> source) => Task.Run(() => source.ToArray());

        /// <summary>Creates a read-only collection from a <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create an array from.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>An array that contains the elements from the input sequence.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static IReadOnlyCollection<TSource> ToReadOnlyCollection<TSource>(this IEnumerable<TSource> source) => new ReadOnlyCollection<TSource>(source.ToList());

        /// <summary>Creates a read-only collection from a <see cref="T:System.Collections.Generic.IEnumerable`1" /> asynchronously.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to create an array from.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>An array that contains the elements from the input sequence.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static async Task<IReadOnlyCollection<TSource>> ToReadOnlyCollectionAsync<TSource>(this IEnumerable<TSource> source) => new ReadOnlyCollection<TSource>(await source.ToListAsync());
    }
}