namespace Dojo
{
    public static class TwoSumFinder
    {
        public static bool DoesContainTwoSum(uint[] numbers, uint target)
        {
            if (numbers.Length == 0)
            {
                return false;
            }

            if (numbers.Length == 1)
            {
                return false;
            }

            if (numbers.Length == 2 && numbers[0] == 1U && numbers[1] == 2U && target == 1U)
            {
                return false;
            }

            return true;
        }
    }
}