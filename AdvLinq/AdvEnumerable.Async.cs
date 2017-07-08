using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>
        /// Performs the specified action on each element of the <see cref="T:System.Collections.Generic.IEnumerable`1" />. 
        /// The whole process is asynchronously, and not each individual action.
        /// This is different from Parallel.ForEach
        /// NOTE: THIS ENUMERATES THE SEQUENCE.
        /// </summary>
        /// <param name="input">A sequence of values to enumerate and run the action on</param>
        /// <param name="action">The <see cref="T:System.Action`1" /> delegate to perform on each element of the <see cref="T:System.Collections.Generic.IEnumerable`1" />.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="action" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">An element in the collection has been modified. This exception is thrown starting with the .NET Framework 4.5. </exception>
        public static Task ForEachAsync<T>(this IEnumerable<T> input, Action<T> action) => Task.Run(() => input.ForEach(action));

        /// <summary>Creates a task that will complete when all of the <see cref="T:System.Threading.Tasks.Task" /> objects in an enumerable collection have completed.</summary>
        /// <param name="tasks">The tasks to wait on for completion.</param>
        /// <returns>A task that represents the completion of all of the supplied tasks. </returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null. </exception>
        /// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task.</exception>
        public static Task WhenAll(this IEnumerable<Task> tasks) => Task.WhenAll(tasks);

        /// <summary>Creates a task that will complete when all of the <see cref="T:System.Threading.Tasks.Task`1" /> objects in an enumerable collection have completed. </summary>
        /// <param name="tasks">The tasks to wait on for completion. </param>
        /// <typeparam name="TResult">The type of the completed task. </typeparam>
        /// <returns>A task that represents the completion of all of the supplied tasks. </returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
        /// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task. </exception>
        public static Task<TResult[]> WhenAll<TResult>(this IEnumerable<Task<TResult>> tasks) => Task.WhenAll(tasks);

        /// <summary>
        /// Creates a task that will complete when each task from the selector will complete.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to run the selector on.</param>
        /// <param name="toTaskSelector">The selector which returns a Task from each item</param>
        /// <returns>A task that represents the completion of all of the supplied tasks. </returns>
        public static Task WhenAll<TSource>(this IEnumerable<TSource> source, Func<TSource, Task> toTaskSelector) => source.Select(toTaskSelector).WhenAll();

        /// <summary>
        /// Creates a task that will complete when each task from the selector will complete.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the completed task. </typeparam>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to run the selector on.</param>
        /// <param name="toTaskSelector">The selector which returns a Task from each item</param>
        /// <returns>A task that represents the completion of all of the supplied tasks. </returns>
        public static Task<TResult[]> WhenAll<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, Task<TResult>> toTaskSelector) => source.Select(toTaskSelector).WhenAll();

        /// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
        /// <param name="tasks">The tasks to wait on for completion.</param>
        /// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
        /// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
        public static Task<Task> WhenAny(IEnumerable<Task> tasks) => Task.WhenAny(tasks);

        /// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
        /// <param name="tasks">The tasks to wait on for completion.</param>
        /// <typeparam name="TResult">The type of the completed task.</typeparam>
        /// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
        /// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
        public static Task<Task<TResult>> WhenAny<TResult>(this IEnumerable<Task<TResult>> tasks) => Task.WhenAny(tasks);

        /// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to run the selector on.</param>
        /// <param name="toTaskSelector">The selector which returns a Task from each item</param>
        /// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
        public static Task<Task> WhenAny<TSource>(IEnumerable<TSource> source, Func<TSource, Task> toTaskSelector) => WhenAny(source.Select(toTaskSelector)); //source.Select(toTaskSelector).WhenAny();

        /// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TResult">The type of the completed task. </typeparam>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to run the selector on.</param>
        /// <param name="toTaskSelector">The selector which returns a Task from each item</param>
        /// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
        public static Task<Task<TResult>> WhenAny<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, Task<TResult>> toTaskSelector) => source.Select(toTaskSelector).WhenAny();
    }
}