namespace data_structures_algorithms_study.Algorithms.Search;

public static class BinarySearch
{
    public static int BinarySearchIndex(List<int> numberList, int number) // O(log n)
    {
        int low = 0;
        int high = numberList.Count - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            var currencyNumber = numberList[mid];

            if (currencyNumber == number)
                return mid;
            else if (currencyNumber > number)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return -1;
    }

    public static int BinarySearchIterationCount(List<int> numberList, int number)
    {
        int counter = 1;
        int low = 0;
        int high = numberList.Count - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            var currencyNumber = numberList[mid];

            if (currencyNumber == number)
                return counter;
            else if (currencyNumber > number)
            {
                high = mid - 1;
                counter++;
            }
            else
            {
                low = mid + 1;
                counter++;
            }
        }
        return counter;
    }
}
