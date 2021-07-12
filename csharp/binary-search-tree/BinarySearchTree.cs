using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class BinarySearchTree : IEnumerable<int>
{
    public int Value { get; private set; }

    public BinarySearchTree Left { get; private set; }
    public BinarySearchTree Right { get; private set; }

    public BinarySearchTree(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }

    public BinarySearchTree(IEnumerable<int> values) : this(values.First())
    {
        foreach(var value in values.Skip(1)) Add(value);
    }

    public BinarySearchTree Add(int value)
    {
        if(value <= Value) {
            if (Left == null)
                Left = new BinarySearchTree(value);
            else
                Left.Add(value);
        }
        else
        {
            if (Right == null)
                Right = new BinarySearchTree(value);
            else
                Right.Add(value);
        }
        return this;
    }

    public IEnumerator<int> GetEnumerator()
    {
        if(Left != null)
        {
            foreach(var value in Left) yield return value;
        }

        yield return Value;

        if (Right != null)
        {
            foreach (var value in Right) yield return value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
