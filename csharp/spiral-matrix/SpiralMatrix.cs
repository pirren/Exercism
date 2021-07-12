public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        int row = 0;
        int column = 0;
        int count = 1;
        
        while (size > 1)
        {
            for(int i = 0; i < size - 1; i++)
            {
                matrix[row, column++] = count++;
            }

            for (int i = 0; i < size - 1; i++)
            {
                matrix[row++, column] = count++;
            }

            for (int i = 0; i < size - 1; i++)
            {
                matrix[row, column--] = count++;
            }

            for (int i = 0; i < size - 1; i++)
            {
                matrix[row--, column] = count++;
            }

            size -= 2;
            column = ++row;
        }

        if(size == 1)
        {
            matrix[row, column] = count;
        }

        return matrix;
    }
}
