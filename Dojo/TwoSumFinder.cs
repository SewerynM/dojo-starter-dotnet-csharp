namespace Dojo
{
    public static class TwoSumFinder
    {
        public static bool DoesContainTwoSum(uint[] numbers, uint target)
        {
            if (numbers.Length < 2)
            {
                return false;
            }
            

            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i; j < numbers.Length; j++)
                {
                    var a = numbers[i];
                    var b = numbers[j];
                    if (a + b == target)
                    {
                        return true;
                    }
                }
            }



            return false;
        }
    }
}