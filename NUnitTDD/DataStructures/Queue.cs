using System;
using System.Collections.Generic;

namespace NUnitTDD.DataStructures
{
  public class Queue<T>
  {
    private readonly List<T> _list = new List<T>();

    public int Count => _list.Count;

    public void Push(T obj)
    {
      if (obj == null)
        throw new ArgumentNullException();

      _list.Add(obj);
    }
    
    public T Remove()
    {
      if (_list.Count == 0)
        throw new InvalidOperationException();

      var result = _list[0];
      _list.RemoveAt(0);

      return result;
    }


    public T Peek()
    {
      if (_list.Count == 0)
        throw new InvalidOperationException();

      return _list[0];
    }
  }
}