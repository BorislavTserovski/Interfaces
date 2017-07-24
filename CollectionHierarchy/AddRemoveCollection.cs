using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



public class AddRemoveCollection<T> : IEnumerable
{
    public List<T> Items { get; set; }

    public AddRemoveCollection()
    {
        this.Items = new List<T>();
    }

    public int Add(T element)
    {
        this.Items.Insert(0, element);
        return 0;
    }

    public T Remove()
    {
        var element = this.Items.Last();
        this.Items.RemoveAt(this.Items.Count - 1);
        return element;
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

