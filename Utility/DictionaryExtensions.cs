using System.Collections.Generic;
using System.Linq;

namespace CsvViewer.Utility {
    public static class DictionaryExtensions
    {
        /// <summary>
        ///     Check if the <see cref="Dictionary{TKey,TValue}"/> <paramref name="this"/>
        ///     contains the <typeparamref name="TKey"/> <paramref name="key"/>.
        /// </summary>
        public static bool HasKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key)
            => @this.Any(kv => kv.Key.Equals(key));
    }
}