using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvLinq
{
    public static partial class AdvEnumerable
    {
        /// <summary>Determines whether all elements of a sequence are of the given type.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements to apply the predicate to.</param>
        /// <typeparam name="TTarget">The type to test on all the elements in the <paramref name="source" />.</typeparam>
        /// <returns>true if every element of the source sequence is of the given type.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static bool All<TTarget>(this IEnumerable source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            foreach (object item in source)
            {
                if (!(item is TTarget))
                    return false;
            }

            return true;
        }

        /// <summary>Determines asynchronously whether all elements of a sequence satisfy a condition.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>true if every element of the source sequence passes the test in the specified predicate, or if the sequence is empty; otherwise, false.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
        public static Task<bool> AllAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) => Task.Run(() => source.All(predicate));

        /// <summary>Determines asynchronously whether all elements of a sequence are of the given type.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements to apply the predicate to.</param>
        /// <typeparam name="TTarget">The type to test on all the elements in the <paramref name="source" />.</typeparam>
        /// <returns>true if every element of the source sequence is of the given type.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> is null.</exception>
        public static Task<bool> AllAsync<TTarget>(this IEnumerable source) => Task.Run(() => source.All<TTarget>());
    }
}