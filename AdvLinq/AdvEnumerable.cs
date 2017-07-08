using System;
using System.Collections.Generic;

namespace AdvLinq
{
    /// <summary>
    /// Provides additional set of static methods for querying objects that implement <see cref="T:System.Collections.Generic.IEnumerable`1" />.
    /// </summary>
    public static partial class AdvEnumerable
    {
        /// <summary>
        /// Performs the specified action on each element of the <see cref="T:System.Collections.Generic.IEnumerable`1" />. 
        /// NOTE: THIS ENUMERATES THE SEQUENCE.
        /// </summary>
        /// <param name="input">A sequence of values to enumerate and run the action on</param>
        /// <param name="action">The <see cref="T:System.Action`1" /> delegate to perform on each element of the <see cref="T:System.Collections.Generic.IEnumerable`1" />.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="action" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">An element in the collection has been modified. This exception is thrown starting with the .NET Framework 4.5. </exception>
        public static void ForEach<T>(this IEnumerable<T> input, Action<T> action)
        {
            foreach (T item in input)
                action(item);
        }
    }
}