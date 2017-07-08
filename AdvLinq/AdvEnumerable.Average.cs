using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>Computes the average of a sequence of <see cref="T:System.Int32" /> values or returns the <paramref name="fallback"/> if the source contains no elements.</summary>
        /// <param name="source">A sequence of <see cref="T:System.Int32" /> values to calculate the average of.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        public static double AverageOr(this IEnumerable<int> source, double fallback) => source.Cast<int?>().Average() ?? fallback;

        /// <summary>Computes the average of a sequence of nullable <see cref="T:System.Int32" /> values or returns the <paramref name="fallback"/> if the source contains no elements.</summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Int32" /> values to calculate the average of.</param>
        /// /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <returns>The average of the sequence of values, or null if the source sequence is empty or contains only values that are null.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.OverflowException">The sum of the elements in the sequence is larger than <see cref="F:System.Int64.MaxValue" />.</exception>
        public static double AverageOr(this IEnumerable<int?> source, double fallback) => source.Average() ?? fallback;

        /// <summary>Computes the average of a sequence of <see cref="T:System.Int64" /> values or returns the <paramref name="fallback"/> if the source contains no elements.</summary>
        /// <param name="source">A sequence of <see cref="T:System.Int64" /> values to calculate the average of.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        public static double AverageOr(this IEnumerable<long> source, double fallback) => source.Cast<long?>().Average() ?? fallback;

        /// <summary>Computes the average of a sequence of nullable <see cref="T:System.Int64" /> values or returns the <paramref name="fallback"/> if the source contains no elements.</summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Int64" /> values to calculate the average of.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <returns>The average of the sequence of values, or null if the source sequence is empty or contains only values that are null.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.OverflowException">The sum of the elements in the sequence is larger than <see cref="F:System.Int64.MaxValue" />.</exception>
        public static double AverageOr(this IEnumerable<long?> source, double fallback) => source.Average() ?? fallback;

        /// <summary>Computes the average of a sequence of <see cref="T:System.Single" /> values or returns the <paramref name="fallback"/> if the source contains no elements.</summary>
        /// <param name="source">A sequence of <see cref="T:System.Single" /> values to calculate the average of.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        public static float AverageOr(this IEnumerable<float> source, float fallback) => source.Cast<float?>().Average() ?? fallback;

        /// <summary>Computes the average of a sequence of nullable <see cref="T:System.Single" /> values or returns the <paramref name="fallback"/> if the source contains no elements.</summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Single" /> values to calculate the average of.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <returns>The average of the sequence of values, or null if the source sequence is empty or contains only values that are null.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static float AverageOr(this IEnumerable<float?> source, float fallback) => source.Average() ?? fallback;

        /// <summary>Computes the average of a sequence of <see cref="T:System.Double" /> values or returns the <paramref name="fallback"/> if the source contains no elements.</summary>
        /// <param name="source">A sequence of <see cref="T:System.Double" /> values to calculate the average of.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        public static double AverageOr(this IEnumerable<double> source, double fallback) => source.Cast<double?>().Average() ?? fallback;

        /// <summary>Computes the average of a sequence of nullable <see cref="T:System.Double" /> values or returns the <paramref name="fallback"/> if the source contains no elements.</summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Double" /> values to calculate the average of.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <returns>The average of the sequence of values, or null if the source sequence is empty or contains only values that are null.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static double AverageOr(this IEnumerable<double?> source, double fallback) => source.Average() ?? fallback;

        /// <summary>Computes the average of a sequence of <see cref="T:System.Decimal" /> values or returns the <paramref name="fallback"/> if the source contains no elements.</summary>
        /// <param name="source">A sequence of <see cref="T:System.Decimal" /> values to calculate the average of.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        public static decimal AverageOr(this IEnumerable<decimal> source, decimal fallback) => source.Cast<decimal?>().Average() ?? fallback;

        /// <summary>Computes the average of a sequence of nullable <see cref="T:System.Decimal" /> values or returns the <paramref name="fallback"/> if the source contains no elements.</summary>
        /// <param name="source">A sequence of nullable <see cref="T:System.Decimal" /> values to calculate the average of.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <returns>The average of the sequence of values, or null if the source sequence is empty or contains only values that are null.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.OverflowException">The sum of the elements in the sequence is larger than <see cref="F:System.Decimal.MaxValue" />.</exception>
        public static decimal AverageOr(this IEnumerable<decimal?> source, decimal fallback) => source.Average() ?? fallback;

        /// <summary>
        /// Computes the average of a sequence of <see cref="T:System.Int32" /> values that are obtained by invoking a transform function on each element of the input sequence.
        /// Returns the <paramref name="fallback"/> if the source contains no elements.
        /// </summary>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        /// <exception cref="T:System.OverflowException">The sum of the elements in the sequence is larger than <see cref="F:System.Int64.MaxValue" />.</exception>
        public static double AverageOr<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector, double fallback) => source.Select(selector).AverageOr(fallback);

        /// <summary>
        /// Computes the average of a sequence of nullable <see cref="T:System.Int32" /> values that are obtained by invoking a transform function on each element of the input sequence.
        /// Returns the <paramref name="fallback"/> if the source contains no elements.
        /// </summary>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values, or null if the source sequence is empty or contains only values that are null.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="T:System.OverflowException">The sum of the elements in the sequence is larger than <see cref="F:System.Int64.MaxValue" />.</exception>
        public static double AverageOr<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector, double fallback) => source.Select(selector).AverageOr(fallback);

        /// <summary>
        /// Computes the average of a sequence of <see cref="T:System.Int64" /> values that are obtained by invoking a transform function on each element of the input sequence.
        /// Returns the <paramref name="fallback"/> if the source contains no elements.
        /// </summary>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        /// <exception cref="T:System.OverflowException">The sum of the elements in the sequence is larger than <see cref="F:System.Int64.MaxValue" />.</exception>
        public static double AverageOr<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector, double fallback) => source.Select(selector).AverageOr(fallback);

        /// <summary>
        /// Computes the average of a sequence of nullable <see cref="T:System.Int64" /> values that are obtained by invoking a transform function on each element of the input sequence.
        /// Returns the <paramref name="fallback"/> if the source contains no elements.
        /// </summary>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values, or null if the source sequence is empty or contains only values that are null.</returns>
        public static double AverageOr<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector, double fallback) => source.Select(selector).AverageOr(fallback);

        /// <summary>
        /// Computes the average of a sequence of <see cref="T:System.Single" /> values that are obtained by invoking a transform function on each element of the input sequence.
        /// Returns the <paramref name="fallback"/> if the source contains no elements.
        /// </summary>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        public static float AverageOr<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector, float fallback) => source.Select(selector).AverageOr(fallback);

        /// <summary>
        /// Computes the average of a sequence of nullable <see cref="T:System.Single" /> values that are obtained by invoking a transform function on each element of the input sequence.
        /// Returns the <paramref name="fallback"/> if the source contains no elements.
        /// </summary>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values, or null if the source sequence is empty or contains only values that are null.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
        public static float AverageOr<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector, float fallback) => source.Select(selector).AverageOr(fallback);

        /// <summary>
        /// Computes the average of a sequence of <see cref="T:System.Double" /> values that are obtained by invoking a transform function on each element of the input sequence.
        /// Returns the <paramref name="fallback"/> if the source contains no elements.
        /// </summary>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        public static double AverageOr<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector, double fallback) => source.Select(selector).AverageOr(fallback);

        /// <summary>
        /// Computes the average of a sequence of nullable <see cref="T:System.Double" /> values that are obtained by invoking a transform function on each element of the input sequence.
        /// Returns the <paramref name="fallback"/> if the source contains no elements.
        /// </summary>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values, or null if the source sequence is empty or contains only values that are null.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
        public static double AverageOr<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector, double fallback) => source.Select(selector).AverageOr(fallback);

        /// <summary>
        /// Computes the average of a sequence of <see cref="T:System.Decimal" /> values that are obtained by invoking a transform function on each element of the input sequence.
        /// Returns the <paramref name="fallback"/> if the source contains no elements.
        /// </summary>
        /// <param name="source">A sequence of values that are used to calculate an average.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="source" /> contains no elements.</exception>
        /// <exception cref="T:System.OverflowException">The sum of the elements in the sequence is larger than <see cref="F:System.Decimal.MaxValue" />.</exception>
        public static decimal AverageOr<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector, decimal fallback) => source.Select(selector).AverageOr(fallback);

        /// <summary>
        /// Computes the average of a sequence of nullable <see cref="T:System.Decimal" /> values that are obtained by invoking a transform function on each element of the input sequence.
        /// Returns the <paramref name="fallback"/> if the source contains no elements.
        /// </summary>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <param name="fallback">The fallback value in case the sequence contains no elements</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The average of the sequence of values, or null if the source sequence is empty or contains only values that are null.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="T:System.OverflowException">The sum of the elements in the sequence is larger than <see cref="F:System.Decimal.MaxValue" />.</exception>
        public static decimal AverageOr<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector, decimal fallback) => source.Select(selector).AverageOr(fallback);
    }
}