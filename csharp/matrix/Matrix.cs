using System;
using System.Linq;

public class Matrix
{
    private readonly string[] _matrix;

    public Matrix(string input)
        => _matrix = input.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

    public int[] Row(int row)
        => _matrix[row - 1].Split(new[] { ' ' }).Select(s => int.Parse(s)).ToArray();

    public int[] Column(int col)
        => _matrix.Select(s => int.Parse(s.Split(new [] { ' ' })[col - 1])).ToArray();
}