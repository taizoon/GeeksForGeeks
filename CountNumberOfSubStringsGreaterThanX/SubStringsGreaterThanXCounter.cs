namespace CountNumberOfSubStringsGreaterThanX
{
    public class SubStringsGreaterThanXCounter
    {
        public int Count(string str, int x)
        {
            var numberOfSubStringsGreaterThanX = 0;

            for (var i = 0; i < str.Length; i++)
            {
                for (var j = 1; j <= str.Length - i; j++)
                {
                    if (str[i] != '0' && int.Parse(str.Substring(i, j)) > x)
                    {
                        numberOfSubStringsGreaterThanX++;
                    }
                }
            }

            return numberOfSubStringsGreaterThanX;
        }
    }
}
