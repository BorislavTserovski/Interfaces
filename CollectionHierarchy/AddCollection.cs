using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



public class AddCollection<T> : IEnumerable
{
    public List<T> Items { get; set; }

    public AddCollection()
    {
        this.Items = new List<T>();
    }
    public int Add(T element)
    {
        this.Items.Add(element);
        return this.Items.Count - 1;
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

