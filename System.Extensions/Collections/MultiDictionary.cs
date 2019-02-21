using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Collections.Multi
{
    public class MultiDictionary<TKey, TValue>
        : MultiDictionary<TKey, TValue, Dictionary<TKey, List<TValue>>, List<TValue>>
    { }

    public interface IReadOnlyMultiDictionary<TKey, TValue>
        : IReadOnlyDictionary<TKey, TValue>, IReadOnlyDictionary<TKey, IReadOnlyList<TValue>>
    { }

    public interface IMultiDictionary<TKey, TValue>
        : IDictionary<TKey, TValue>, IReadOnlyMultiDictionary<TKey, TValue>
    { }

    public class MultiDictionary<TKey, TValue, TDictionary, TList>
        : IMultiDictionary<TKey, TValue>
        where TDictionary : IDictionary<TKey, TList>, new()
        where TList : IList<TValue>, new()
    {
        private TDictionary innerDic { get; } = new TDictionary();
        
        public TValue this[TKey key] {
            get => this.innerDic[key][0];
            set {
                if (this.innerDic.ContainsKey(key))
                {
                    this.innerDic[key].Add(value);
                }
                else
                {
                    this.innerDic[key] = new TList { value };
                }
            }
        }

        IReadOnlyList<TValue> IReadOnlyDictionary<TKey, IReadOnlyList<TValue>>.this[TKey key]
            => this.innerDic[key].AsReadOnlyCollection();

        public IEnumerable<TKey> Keys
            => this.innerDic.Keys;

        ICollection<TKey> IDictionary<TKey, TValue>.Keys
            => this.innerDic.Keys;

        public IEnumerable<TValue> Values
            => this.innerDic.Values.SelectMany(e => e);

        ICollection<TValue> IDictionary<TKey, TValue>.Values
            => new ValueCollection(this);

        IEnumerable<IReadOnlyList<TValue>> IReadOnlyDictionary<TKey, IReadOnlyList<TValue>>.Values
            => this.innerDic.Values.Select(e => e.AsReadOnlyCollection());

        public int Count
            => this.innerDic.Values.Sum(e => e.Count);

        public bool IsReadOnly
            => false;

        public void Add(TKey key, TValue value)
        {
            if (this.innerDic.TryGetValue(key, out var list))
            {
                list.Add(value);
            }
            else
            {
                this.innerDic.Add(key, new TList() { value });
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
            => this.Add(item.Key, item.Value);

        public void Clear()
            => this.innerDic.Clear();

        public bool Contains(KeyValuePair<TKey, TValue> item)
            => this.innerDic.TryGetValue(item.Key, out var list) && list.Contains(item.Value);

        public bool ContainsKey(TKey key)
            => this.innerDic.ContainsKey(key);

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
            => ((IEnumerable<KeyValuePair<TKey, TValue>>)this).ForEach((item, i) => array[i + arrayIndex] = item);

        public bool Remove(TKey key)
            => this.innerDic.Remove(key);

        public bool Remove(KeyValuePair<TKey, TValue> item)
            => this.innerDic.TryGetValue(item.Key, out var list)
                && list.Remove(item.Value)
                && (list.Count == 0 ? this.innerDic.Remove(item.Key) : true);

        public bool TryGetValue(TKey key, out TValue value)
        {
            var hasValue = this.innerDic.TryGetValue(key, out var list);
            value = hasValue ? list[0] : default;
            return hasValue;
        }

        public bool TryGetValue(TKey key, out IReadOnlyList<TValue> value)
        {
            var hasValue = this.innerDic.TryGetValue(key, out var list);
            value = hasValue ? list.AsReadOnlyCollection() : default;
            return hasValue;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
            => this.innerDic.SelectMany(e => e.Value.Select(x => KeyValuePair.Create(e.Key, x))).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();

        IEnumerator<KeyValuePair<TKey, IReadOnlyList<TValue>>> IEnumerable<KeyValuePair<TKey, IReadOnlyList<TValue>>>.GetEnumerator()
            => this.innerDic.Select(e => KeyValuePair.Create(e.Key, (IReadOnlyList<TValue>)e.Value.AsReadOnlyCollection())).GetEnumerator();

        private struct ValueCollection: ICollection<TValue>
        {
            private MultiDictionary<TKey, TValue, TDictionary, TList> dic { get; }

            public ValueCollection(MultiDictionary<TKey, TValue, TDictionary, TList> dic)
            {
                this.dic = dic;
            }

            public int Count
                => this.dic.Count;

            public bool IsReadOnly
                => true;

            public bool Contains(TValue item)
                => this.dic.innerDic.Values.Any(e => e.Contains(item));

            public IEnumerator<TValue> GetEnumerator()
                => this.dic.Values.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator()
                => this.GetEnumerator();

            public void CopyTo(TValue[] array, int arrayIndex)
                => this.dic.innerDic.Values.Aggregate((array, arrayIndex), (r, e) => {
                    e.CopyTo(r.array, r.arrayIndex);
                    return (r.array, r.arrayIndex + e.Count);
                });

            public void Add(TValue item)
                => throw new NotSupportedException();

            public void Clear()
                => throw new NotSupportedException();

            public bool Remove(TValue item)
                => throw new NotSupportedException();
        }
    }
}
