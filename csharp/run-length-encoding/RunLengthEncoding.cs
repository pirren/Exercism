using System.Text;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        StringBuilder sb = new StringBuilder();
        
        while(string.IsNullOrEmpty(input) == false)
        {
            StringBuilder block = new StringBuilder();
            var ch = input[0];
            int count = 0;

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == ch)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            if (count > 1) block.Append(count);
            block.Append(ch);

            input = input.Remove(0, count);

            if (block != null)
            {
                sb.Append(block);
            }
        }

        return sb.ToString();
    }

    public static string Decode(string input)
    {
        StringBuilder sb = new StringBuilder();

        while(string.IsNullOrEmpty(input) == false)
        {
            string numericPositions = string.Empty;
            int countBlock = 1;
            for(int i = 0; i < input.Length; i++)
            {
                if(int.TryParse(input[i].ToString(), out int _))
                {
                    numericPositions += input[i];
                }
                else
                {
                    break;
                }
            }
            if(string.IsNullOrEmpty(numericPositions) == false)
            {
                countBlock = int.Parse(numericPositions);
                input = input.Remove(0, numericPositions.Length);
            }

            char ch = input[0];
            input = input.Remove(0, 1);

            for (int i = 0; i < countBlock; i++)
            {
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }
}
