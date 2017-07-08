using System;
using System.Collections.Generic;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>Projects each element of a sequence into a new form.</summary>
        /// <param name="source">A sequence of values to invoke a transform function on.</param>
        /// <param name="predicate">The predicate to run on each item</param>
        /// <param name="trueSelector">A transform function to apply to elements that passed the predicate.</param>
        /// <param name="falseSelector">A transform function to apply to elements that failed the predicate.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by <paramref name="trueSelector" /> and by <paramref name="falseSelector" />.</typeparam>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the transform functions on each element of <paramref name="source" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" />, <paramref name="trueSelector" /> or <paramref name="falseSelector" /> is null.</exception>
        public static IEnumerable<TResult> SelectIf<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> trueSelector, Func<TSource, TResult> falseSelector)
        {
            foreach (TSource inputItem in source)
            {
                yield return predicate(inputItem)
                    ? trueSelector(inputItem)
                    : falseSelector(inputItem);
            }
        }

        /// <summary>Projects each element of a sequence into a new form.</summary>
        /// <param name="source">A sequence of values to invoke a transform function on.</param>
        /// <param name="predicate">The predicate to run on each item</param>
        /// <param name="trueSelector">A transform function to apply to elements that passed the predicate.</param>
        /// <param name="falseSelector">A transform function to apply to elements that failed the predicate.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by <paramref name="trueSelector" /> and by <paramref name="falseSelector" />.</typeparam>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the transform functions on each element of <paramref name="source" />.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" />, <paramref name="trueSelector" /> or <paramref name="falseSelector" /> is null.</exception>
        public static IEnumerable<TResult> SelectIf<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, int, TResult> trueSelector, Func<TSource, int, TResult> falseSelector)
        {
            int index = 0;
            foreach (TSource inputItem in source)
            {
                yield return predicate(inputItem)
                    ? trueSelector(inputItem, index++)
                    : falseSelector(inputItem, index++);
            }
        }
    }
}