using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>Determines whether a sequence contains a specified element exactly <paramref name="occurrences"/> times by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> .</summary>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="occurrences">The exact number of occurrences of <paramref name="value"/>.</param>
        /// <param name="comparer">An equality comparer to compare values. (Can be null for default comparer)</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <paramref name="occurrences"/> is less then 0.
        /// </exception>
        public static bool ContainsExactly<TSource>(this IEnumerable<TSource> source, TSource value, int occurrences, EqualityComparer<TSource> comparer = null)
        {
            if (comparer == null) comparer = EqualityComparer<TSource>.Default;
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (occurrences < 0) throw new ArgumentOutOfRangeException(nameof(occurrences), $"The value of {nameof(occurrences)} must be a non-negative integer.");

            int counter = 0;
            foreach (TSource element in source)
            {
                if (comparer.Equals(element, value))
                    counter++;

                if (counter > occurrences)
                    return false;
            }

            return counter == occurrences;
        }

        /// <summary>Determines whether a sequence contains a specified element at least <paramref name="occurrences"/> times by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> .</summary>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="occurrences">The exact number of occurrences of <paramref name="value"/>.</param>
        /// <param name="comparer">An equality comparer to compare values. (Can be null for default comparer)</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <paramref name="occurrences"/> is less then 1.
        /// </exception>
        public static bool ContainsAtLeast<TSource>(this IEnumerable<TSource> source, TSource value, int occurrences, EqualityComparer<TSource> comparer = null)
        {
            if (comparer == null) comparer = EqualityComparer<TSource>.Default;
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (occurrences < 0) throw new ArgumentOutOfRangeException(nameof(occurrences), $"The value of {nameof(occurrences)} must be a non-negative integer.");

            if (occurrences == 0)
                return true;

            if (occurrences == 1)
                return source.Contains(value, comparer);

            int counter = 0;
            foreach (TSource element in source)
            {
                if (comparer.Equals(element, value))
                    counter++;

                if (counter > occurrences)
                    return true;
            }

            return counter == occurrences;
        }

        /// <summary>Determines whether a sequence contains a specified element at most <paramref name="occurrences"/> times by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> .</summary>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="occurrences">The exact number of occurrences of <paramref name="value"/>.</param>
        /// <param name="comparer">An equality comparer to compare values. (Can be null for default comparer)</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <paramref name="occurrences"/> is less then 0.
        /// </exception>
        public static bool ContainsAtMost<TSource>(this IEnumerable<TSource> source, TSource value, int occurrences, EqualityComparer<TSource> comparer = null)
        {
            if (comparer == null) comparer = EqualityComparer<TSource>.Default;
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (occurrences < 0) throw new ArgumentOutOfRangeException(nameof(occurrences), $"The value of {nameof(occurrences)} must be a non-negative integer.");

            if (occurrences == 0)
                return !source.Contains(value, comparer);

            int counter = 0;
            foreach (TSource element in source)
            {
                if (comparer.Equals(element, value))
                    counter++;

                if (counter > occurrences)
                    return false;
            }

            return counter <= occurrences;
        }

        /// <summary>Determines asynchronously whether a sequence contains a specified element exactly <paramref name="occurrences"/> times by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> .</summary>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="occurrences">The exact number of occurrences of <paramref name="value"/>.</param>
        /// <param name="comparer">An equality comparer to compare values. (Can be null for default comparer)</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <paramref name="occurrences"/> is less then 0.
        /// </exception>
        public static Task<bool> ContainsExactlyAsync<TSource>(this IEnumerable<TSource> source, TSource value, int occurrences, EqualityComparer<TSource> comparer = null) => Task.Run(() => source.ContainsExactly(value, occurrences, comparer));

        /// <summary>Determines asynchronously whether a sequence contains a specified element at least <paramref name="occurrences"/> times by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> .</summary>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="occurrences">The exact number of occurrences of <paramref name="value"/>.</param>
        /// <param name="comparer">An equality comparer to compare values. (Can be null for default comparer)</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <paramref name="occurrences"/> is less then 1.
        /// </exception>
        public static Task<bool> ContainsAtLeastAsync<TSource>(this IEnumerable<TSource> source, TSource value, int occurrences, EqualityComparer<TSource> comparer = null) => Task.Run(() => source.ContainsAtLeast(value, occurrences, comparer));

        /// <summary>Determines asynchronously whether a sequence contains a specified element at most <paramref name="occurrences"/> times by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> .</summary>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="occurrences">The exact number of occurrences of <paramref name="value"/>.</param>
        /// <param name="comparer">An equality comparer to compare values. (Can be null for default comparer)</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <paramref name="occurrences"/> is less then 0.
        /// </exception>
        public static Task<bool> ContainsAtMostAsync<TSource>(this IEnumerable<TSource> source, TSource value, int occurrences, EqualityComparer<TSource> comparer = null) => Task.Run(() => source.ContainsAtMost(value, occurrences, comparer));

        /// <summary>Determines asynchronously whether a sequence contains a specified element by using the default equality comparer.</summary>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static Task<bool> ContainsAsync<TSource>(this IEnumerable<TSource> source, TSource value) => Task.Run(() => source.Contains(value));

        /// <summary>Determines asynchronously whether a sequence contains a specified element by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="comparer">An equality comparer to compare values.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static Task<bool> ContainsAsync<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) => Task.Run(() => source.Contains(value, comparer));
    }
}