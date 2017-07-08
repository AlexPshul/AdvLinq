using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>Applies an accumulator function over a sequence asynchronously.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The final accumulator value.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="func" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        public static Task<TSource> AggregateAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func) => Task.Run(() => source.Aggregate(func));

        /// <summary>Applies an accumulator function over a sequence asynchronously. The specified seed value is used as the initial accumulator value.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
        /// <returns>The final accumulator value.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="func" /> is null.</exception>
        public static Task<TAccumulate> AggregateAsync<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func) => Task.Run(() => source.Aggregate(seed, func));

        /// <summary>Applies an accumulator function over a sequence asynchronously. The specified seed value is used as the initial accumulator value, and the specified function is used to select the result value.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
        /// <typeparam name="TResult">The type of the resulting value.</typeparam>
        /// <returns>The transformed final accumulator value.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="func" /> or <paramref name="resultSelector" /> is null.</exception>
        public static Task<TResult> AggregateAsync<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector) => Task.Run(() => source.Aggregate(seed, func, resultSelector));
    }
}