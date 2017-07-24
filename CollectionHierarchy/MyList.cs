using System;
using System.Collections;
using System.Collections.Generic;


public class MyList<T> : IEnumerable
{
    public int Used { get; set; }

    public List<T> Items { get; set; }

    public MyList()
    {
        this.Items = new List<T>();
        this.Used = this.Items.Count;
    }

    public int Add(T element)
    {
        this.Items.Insert(0, element);
        return 0;
    }

    public T Remove()
    {
        var element = this.Items[0];
        this.Items.RemoveAt(0);
        return element;
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

