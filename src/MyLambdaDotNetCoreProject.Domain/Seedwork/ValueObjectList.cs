using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLambdaDotNetCoreProject.Domain.Seedwork
{
    /// <summary>
    /// name: valueobjectlist
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValueObjectList<T> : IEnumerable<T> where T : ValueObject
    {
        private readonly List<T> _items = new List<T>();

        public ValueObjectList(IEnumerable<T> items = null)
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    this._items.Add(item);
                }
            }
        }

        #region valueobjectList immutability

        public ValueObjectList<T> GetItemAddedList(T item)
        {
            var list = new List<T>();

            foreach (var i in this._items)
            {
                list.Add(i);
            }

            list.Add(item);

            return new ValueObjectList<T>(list);
        }

        public ValueObjectList<T> GetItemRemovedList(Func<T, bool> condition)
        {
            var list = new List<T>();

            foreach (var i in this._items.Where(o => !condition(o)))
            {
                list.Add(i);
            }

            return new ValueObjectList<T>(list);
        }

        public ValueObjectList<T> GetCopy()
        {
            var list = new List<T>();

            foreach (var item in this)
            {
                list.Add(item.GetCopy() as T);
            }

            return new ValueObjectList<T>(list);
        }

        #endregion
        IEnumerator IEnumerable.GetEnumerator() => this._items.GetEnumerator();
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => this._items.GetEnumerator();

        public override string ToString() => $"Valueobject list of type ({typeof(T)}). item count : {this._items.Count}";
    }
}

