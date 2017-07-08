using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>
        /// Executes a foreach (For Each in Visual Basic) operation on an <see cref="T:System.Collections.IEnumerable" /> in which iterations may run in parallel.
        /// </summary>
        /// <param name="source">An enumerable data source.</param>
        /// <param name="body">The delegate that is invoked once per iteration.</param>
        /// <typeparam name="TSource">The type of the data in the source.</typeparam>
        /// <returns>A structure that contains information about which portion of the loop completed.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="source" /> argument is null.-or-The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        public static ParallelLoopResult ForEachParallel<TSource>(this IEnumerable<TSource> source, Action<TSource> body) => Parallel.ForEach(source, body);

        /// <summary>Executes a foreach (For Each in Visual Basic) operation on an <see cref="T:System.Collections.IEnumerable" /> in which iterations may run in parallel and loop options can be configured.</summary>
        /// <param name="source">An enumerable data source.</param>
        /// <param name="parallelOptions">An object that configures the behavior of this operation.</param>
        /// <param name="body">The delegate that is invoked once per iteration.</param>
        /// <typeparam name="TSource">The type of the data in the source.</typeparam>
        /// <returns>A structure that contains information about which portion of the loop completed.</returns>
        /// <exception cref="T:System.OperationCanceledException">The <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> argument is canceled</exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="source" /> argument is null.-or-The <paramref name="parallelOptions" /> argument is null.-or-The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with the <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> has been disposed.</exception>
        public static ParallelLoopResult ForEachParallel<TSource>(this IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource> body) => Parallel.ForEach(source, parallelOptions, body);

        /// <summary>Executes a foreach (For Each in Visual Basic) operation on an <see cref="T:System.Collections.IEnumerable" /> in which iterations may run in parallel, and the state of the loop can be monitored and manipulated.</summary>
        /// <param name="source">An enumerable data source.</param>
        /// <param name="body">The delegate that is invoked once per iteration.</param>
        /// <typeparam name="TSource">The type of the data in the source.</typeparam>
        /// <returns>A structure that contains information about which portion of the loop completed.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="source" /> argument is null.-or-The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        public static ParallelLoopResult ForEachParallel<TSource>(this IEnumerable<TSource> source, Action<TSource, ParallelLoopState> body) => Parallel.ForEach(source, body);

        /// <summary>Executes a foreach (For Each in Visual Basic) operation on an <see cref="T:System.Collections.IEnumerable" /> in which iterations may run in parallel, loop options can be configured, and the state of the loop can be monitored and manipulated.</summary>
        /// <param name="source">An enumerable data source.</param>
        /// <param name="parallelOptions">An object that configures the behavior of this operation.</param>
        /// <param name="body">The delegate that is invoked once per iteration.</param>
        /// <typeparam name="TSource">The type of the data in the source.</typeparam>
        /// <returns>A structure that contains information about which portion of the loop completed.</returns>
        /// <exception cref="T:System.OperationCanceledException">The <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> argument is canceled</exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="source" /> argument is null.-or-The <paramref name="parallelOptions" /> argument is null.-or-The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with the <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> has been disposed.</exception>
        public static ParallelLoopResult ForEachParallel<TSource>(this IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState> body) => Parallel.ForEach(source, parallelOptions, body);

        /// <summary>Executes a foreach (For Each in Visual Basic) operation with 64-bit indexes on an <see cref="T:System.Collections.IEnumerable" /> in which iterations may run in parallel, and the state of the loop can be monitored and manipulated.</summary>
        /// <param name="source">An enumerable data source.</param>
        /// <param name="body">The delegate that is invoked once per iteration.</param>
        /// <typeparam name="TSource">The type of the data in the source.</typeparam>
        /// <returns>A structure that contains information about which portion of the loop completed.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="source" /> argument is null.-or-The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        public static ParallelLoopResult ForEachParallel<TSource>(this IEnumerable<TSource> source, Action<TSource, ParallelLoopState, long> body) => Parallel.ForEach(source, body);

        /// <summary>Executes a foreach (For Each in Visual Basic) operation with 64-bit indexes on an <see cref="T:System.Collections.IEnumerable" /> in which iterations may run in parallel, loop options can be configured, and the state of the loop can be monitored and manipulated.</summary>
        /// <param name="source">An enumerable data source.</param>
        /// <param name="parallelOptions">An object that configures the behavior of this operation.</param>
        /// <param name="body">The delegate that is invoked once per iteration.</param>
        /// <typeparam name="TSource">The type of the data in the source.</typeparam>
        /// <returns>A structure that contains information about which portion of the loop completed.</returns>
        /// <exception cref="T:System.OperationCanceledException">The <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> argument is canceled</exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="source" /> argument is null.-or-The <paramref name="parallelOptions" /> argument is null.-or-The <paramref name="body" /> argument is null.</exception>
        /// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with the <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> has been disposed.</exception>
        public static ParallelLoopResult ForEachParallel<TSource>(this IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState, long> body) => Parallel.ForEach(source, parallelOptions, body);

        /// <summary>Executes a foreach (For Each in Visual Basic) operation with thread-local data on an <see cref="T:System.Collections.IEnumerable" /> in which iterations may run in parallel, and the state of the loop can be monitored and manipulated.</summary>
        /// <param name="source">An enumerable data source.</param>
        /// <param name="localInit">The function delegate that returns the initial state of the local data for each task.</param>
        /// <param name="body">The delegate that is invoked once per iteration.</param>
        /// <param name="localFinally">The delegate that performs a final action on the local state of each task.</param>
        /// <typeparam name="TSource">The type of the data in the source.</typeparam>
        /// <typeparam name="TLocal">The type of the thread-local data.</typeparam>
        /// <returns>A structure that contains information about which portion of the loop completed.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="source" /> argument is null.-or-The <paramref name="body" /> argument is null.-or-The <paramref name="localInit" /> argument is null.-or-The <paramref name="localFinally" /> argument is null.</exception>
        /// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        public static ParallelLoopResult ForEachParallel<TSource, TLocal>(this IEnumerable<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
            => Parallel.ForEach(source, localInit, body, localFinally);

        /// <summary>Executes a foreach (For Each in Visual Basic) operation with thread-local data on an <see cref="T:System.Collections.IEnumerable" /> in which iterations may run in parallel, loop options can be configured, and the state of the loop can be monitored and manipulated..</summary>
        /// <param name="source">An enumerable data source.</param>
        /// <param name="parallelOptions">An object that configures the behavior of this operation.</param>
        /// <param name="localInit">The function delegate that returns the initial state of the local data for each task.</param>
        /// <param name="body">The delegate that is invoked once per iteration.</param>
        /// <param name="localFinally">The delegate that performs a final action on the local state of each task.</param>
        /// <typeparam name="TSource">The type of the data in the source.</typeparam>
        /// <typeparam name="TLocal">The type of the thread-local data.</typeparam>
        /// <returns>A structure that contains information about which portion of the loop completed.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="source" /> argument is null.-or-The <paramref name="parallelOptions" /> argument is null.-or-The <paramref name="body" /> argument is null.-or-The <paramref name="localInit" /> argument is null.-or-The <paramref name="localFinally" /> argument is null.</exception>
        /// <exception cref="T:System.OperationCanceledException">The <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> argument is canceled.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with the <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> has been disposed.</exception>
        /// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        public static ParallelLoopResult ForEachParallel<TSource, TLocal>(this IEnumerable<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
            => Parallel.ForEach(source, parallelOptions, localInit, body, localFinally);

        /// <summary>Executes a foreach (For Each in Visual Basic) operation with thread-local data on an <see cref="T:System.Collections.IEnumerable" /> in which iterations may run in parallel and the state of the loop can be monitored and manipulated.</summary>
        /// <param name="source">An enumerable data source.</param>
        /// <param name="localInit">The function delegate that returns the initial state of the local data for each task.</param>
        /// <param name="body">The delegate that is invoked once per iteration.</param>
        /// <param name="localFinally">The delegate that performs a final action on the local state of each task.</param>
        /// <typeparam name="TSource">The type of the data in the source.</typeparam>
        /// <typeparam name="TLocal">The type of the thread-local data.</typeparam>
        /// <returns>A structure that contains information about which portion of the loop completed.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="source" /> argument is null.-or-The <paramref name="body" /> argument is null.-or-The <paramref name="localInit" /> argument is null.-or-The <paramref name="localFinally" /> argument is null.</exception>
        /// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        public static ParallelLoopResult ForEachParallel<TSource, TLocal>(this IEnumerable<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally)
            => Parallel.ForEach(source, localInit, body, localFinally);

        /// <summary>Executes a foreach (For Each in Visual Basic) operation with thread-local data and 64-bit indexes on an <see cref="T:System.Collections.IEnumerable" /> in which iterations may run in parallel, loop options can be configured, and the state of the loop can be monitored and manipulated.</summary>
        /// <param name="source">An enumerable data source.</param>
        /// <param name="parallelOptions">An object that configures the behavior of this operation.</param>
        /// <param name="localInit">The function delegate that returns the initial state of the local data for each task.</param>
        /// <param name="body">The delegate that is invoked once per iteration.</param>
        /// <param name="localFinally">The delegate that performs a final action on the local state of each task.</param>
        /// <typeparam name="TSource">The type of the data in the source.</typeparam>
        /// <typeparam name="TLocal">The type of the thread-local data.</typeparam>
        /// <returns>A structure that contains information about which portion of the loop completed.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="source" /> argument is null.-or-The <paramref name="parallelOptions" /> argument is null.-or-The <paramref name="body" /> argument is null.-or-The <paramref name="localInit" /> argument is null.-or-The <paramref name="localFinally" /> argument is null.</exception>
        /// <exception cref="T:System.OperationCanceledException">The <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> argument is canceled.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with the <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> has been disposed.</exception>
        /// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
        public static ParallelLoopResult ForEachParallel<TSource, TLocal>(
            this IEnumerable<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally)
            => Parallel.ForEach(source, parallelOptions, localInit, body, localFinally);
    }
}